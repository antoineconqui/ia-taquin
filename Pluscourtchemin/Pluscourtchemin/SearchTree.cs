using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pluscourtchemin
{
    public class SearchTree
    {
        public List<GenericNode> OpenedNodes;
        public List<GenericNode> ClosedNodes;
        public int opened;
        public int closed;

        private GenericNode isClosed(GenericNode node0)
        {
            foreach (GenericNode node in ClosedNodes)
                if (node.IsEqual(node0))
                    return node0;
            return null;
        }

        private GenericNode isOpened(GenericNode node0)
        {
            foreach (GenericNode node in OpenedNodes)
                if (node.IsEqual(node0))
                    return node0;
            return null;
        }

        public List<GenericNode> findSolution(GenericNode node0, bool human, int _chosenSize)
        {
            if(human)
                return findHumanSolution(node0, _chosenSize);
            else
                return findManhattanSolution(node0);
        }

        public List<GenericNode> findManhattanSolution(GenericNode node0)
        {
            OpenedNodes = new List<GenericNode>();
            ClosedNodes = new List<GenericNode>();
            GenericNode node = node0;
            OpenedNodes.Add(node0);

            while (OpenedNodes.Count > 0 && !node.EndState())
            {
                OpenedNodes.Remove(node);
                ClosedNodes.Add(node);
                this.getSuccessors(node);
                if (OpenedNodes.Count > 0)
                {
                    node = OpenedNodes[0];
                    node.getTotalCost();
                }
                else
                    node = null;
            }

            List<GenericNode> nodeList = new List<GenericNode>();
            if (node != null)
            {
                nodeList.Add(node);
                while (node != node0)
                {
                    node = node.parent;
                    nodeList.Insert(0, node);
                }
            }

            opened = OpenedNodes.Count;
            closed = ClosedNodes.Count;
            return nodeList;
        }

        public List<GenericNode> findHumanSolution(GenericNode node0, int _chosenSize)
        {
            opened = closed = 0;
            List<GenericNode> completePath = new List<GenericNode>();
            List<int> placedNumbers = new List<int>();

            for (int i = 0; i < _chosenSize - 2; i++)
            {
                for (int j = 0; j < _chosenSize; j++)
                {
                    List<GenericNode> partialPath = findPartialPath(node0, placedNumbers, i * _chosenSize + j + 1);

                    foreach (GenericNode node in partialPath)
                        completePath.Add(node);

                    node0 = partialPath[partialPath.Count - 1];
                    placedNumbers.Add(i * _chosenSize + j + 1);
                }
            }

            for (int i = 0; i < _chosenSize; i++)
            {
                List<GenericNode> humanPath = findPartialPath(node0, placedNumbers, (_chosenSize - 2) * _chosenSize + i + 1);

                foreach (GenericNode noeud in humanPath)
                    completePath.Add(noeud);

                node0 = humanPath[humanPath.Count - 1];
                placedNumbers.Add( (_chosenSize - 2) * _chosenSize + i + 1);

                if (i < _chosenSize - 2)
                {
                    List<GenericNode> humanPathBis = findPartialPath(node0, placedNumbers, (_chosenSize - 1) * _chosenSize + i + 1);

                    foreach (GenericNode noeud in humanPathBis)
                        completePath.Add(noeud);

                    node0 = humanPathBis[humanPathBis.Count - 1];
                    placedNumbers.Add( (_chosenSize - 1) * _chosenSize + i + 1);
                }
            }

            List<GenericNode> finalPath = new List<GenericNode>();

            for (int i = 0; i < completePath.Count-1; i++)
                if (completePath[i] != completePath[i + 1])
                    finalPath.Add(completePath[i]);
            finalPath.Add(completePath[completePath .Count- 1]);

            return finalPath;
        }

        public List<GenericNode> findPartialPath(GenericNode node0, List<int> placedNumbers, int currentNumber)
        {
            OpenedNodes = new List<GenericNode>();
            ClosedNodes = new List<GenericNode>();
            GenericNode node = node0;
            OpenedNodes.Add(node0);
            
            while (OpenedNodes.Count != 0 && !node.isPartiallyFinal(currentNumber))
            {
                OpenedNodes.Remove(node);
                ClosedNodes.Add(node);

                this.getPartialSuccessors(node, placedNumbers, currentNumber);
                
                if (OpenedNodes.Count > 0)
                    node = OpenedNodes[0];
                else
                    node = null;
            }

            List<GenericNode> nodeList = new List<GenericNode>();
            if (node != null)
            {
                nodeList.Add(node);
                
                while (node != node0)
                {
                    node = node.parent;
                    nodeList.Insert(0, node);
                }
            }

            opened += OpenedNodes.Count;
            closed += ClosedNodes.Count;
            return nodeList;
        }
        
        private void getSuccessors(GenericNode node0)
        {
            foreach (GenericNode node in node0.getSuccessors())
            {
                GenericNode nodeBis = isClosed(node);
                if (nodeBis == null)
                {
                    nodeBis = isOpened(node);
                    if (nodeBis != null)
                    {
                        if (node0.initialCost + 1 < nodeBis.initialCost)
                        {
                            nodeBis.initialCost = node0.initialCost + 1;
                            nodeBis.getTotalCost();
                            nodeBis.parent = node0;
                            OpenedNodes.Remove(nodeBis);
                            this.openNode(nodeBis);
                        }
                    }
                    else
                    {
                        node.initialCost = node0.initialCost + 1;
                        node.parent = node0;
                        node.getTotalCost();
                        this.openNode(node);
                    }
                }
            }
        }

        private void getPartialSuccessors(GenericNode node0, List<int> placedNumbers, int currentNumber)
        {
            foreach (GenericNode node in node0.getPartialSuccessors(placedNumbers))
            {
                GenericNode nodeBis = isClosed(node);
                if (nodeBis == null)
                {
                    nodeBis = isOpened(node);
                    if (nodeBis != null)
                    {
                        if (node0.initialCost + 1 < nodeBis.initialCost)
                        {
                            nodeBis.initialCost = node0.initialCost + 1;
                            nodeBis.totalCost = nodeBis.initialCost + nodeBis.heuristicCost;
                            nodeBis.parent  = node0;
                            OpenedNodes.Remove(nodeBis);
                            this.openNode(nodeBis);
                        }
                    }
                    else
                    {
                        node.initialCost = node0.initialCost + 1;
                        node.parent  = node0;
                        node.getHumanTotalCost(currentNumber);
                        this.openNode(node);
                    }
                }
            }
        }

        public void openNode(GenericNode newNode)
        {
            if (this.OpenedNodes.Count == 0)
                OpenedNodes.Add(newNode);
            else
            {
                for (int i = 0; i < OpenedNodes.Count; i++)
                {
                    if (newNode.totalCost < OpenedNodes[i].totalCost)
                    {
                        OpenedNodes.Insert(i, newNode);
                        return;
                    }
                }
                OpenedNodes.Insert(OpenedNodes.Count, newNode);
            }
        }

        public void GetTreeView(TreeView treeView)
        {
            if (ClosedNodes == null) return;
            if (ClosedNodes.Count == 0) return;

            treeView.Nodes.Clear();

            TreeNode treeNode = new TreeNode(ClosedNodes[0].ToString());
            treeView.Nodes.Add(treeNode);

            addBranche(ClosedNodes[0], treeNode);
        }

        private void addBranche(GenericNode node0, TreeNode treeNode)
        {
            foreach (GenericNode successor in node0.successors)
            {
                TreeNode node = new TreeNode(successor.ToString());
                treeNode.Nodes.Add(node);
                if (successor.successors.Count > 0)
                    addBranche(successor, node);
            }
        }

    }
}
