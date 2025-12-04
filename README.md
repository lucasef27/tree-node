# Tree Node Builder  
**Binary Tree Construction Based on Array Rules**

This project demonstrates an algorithm that builds a binary tree from an integer array following specific structural rules:

### **Tree Construction Rules**
- The **root** of the tree is the **highest value in the array**.  
- The **left branch** contains only the numbers **to the left** of the root in the array, arranged in **descending order**.  
- The **right branch** contains only the numbers **to the right** of the root in the array, also in **descending order**.

### Project Structure

/ConsoleApp
├── Program.cs # Main execution
├── TreeNode.cs # Node definition
└── TreeBuilder.cs # Tree-building logic
