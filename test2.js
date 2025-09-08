// test.js
const readline = require("readline");

const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

// ========================
// Array Demo
// ========================
function arrayDemo() {
  console.log("\n--- Arrays Demo ---");
  let arr = [10, 20, 30, 40];
  console.log("Initial Array:", arr);

  console.time("Access First Element (O(1))");
  console.log("Access index 0:", arr[0]);
  console.timeEnd("Access First Element (O(1))");

  console.time("Unshift Operation (O(n))");
  arr.unshift(5);
  console.timeEnd("Unshift Operation (O(n))");
  console.log("After unshift (insert at start):", arr);

  console.time("Splice Operation (O(n))");
  arr.splice(2, 1);
  console.timeEnd("Splice Operation (O(n))");
  console.log("After splice (remove index 2):", arr);

  console.log("👉 Notice: Arrays allow fast random access (O(1)), but inserting/removing at start/middle shifts elements (O(n)).");
  console.log("--- End of Array Demo ---\n");
}

// ========================
// Linked List Demo
// ========================
function linkedListDemo() {
  console.log("\n--- Linked List Demo ---");

  class Node {
    constructor(data) {
      this.data = data;
      this.next = null;
    }
  }
  class LinkedList {
    constructor() {
      this.head = null;
    }
    append(data) {
      const newNode = new Node(data);
      if (!this.head) {
        this.head = newNode;
        return;
      }
      let temp = this.head;
      while (temp.next) temp = temp.next;
      temp.next = newNode;
    }
    display() {
      let temp = this.head;
      let output = "";
      while (temp) {
        output += temp.data + " -> ";
        temp = temp.next;
      }
      console.log(output + "null");
    }
  }

  const ll = new LinkedList();
  ll.append(10);
  ll.append(20);
  ll.append(30);

  console.time("LinkedList Display");
  ll.display();
  console.timeEnd("LinkedList Display");

  console.log("👉 Notice: Each node stores data + pointer to the next node.");
  console.log("👉 Unlike arrays, there are no indexes. To find something, you must traverse from the head (O(n)).");
  console.log("--- End of Linked List Demo ---\n");
}

// ========================
// Stack Demo
// ========================
function stackDemo() {
  console.log("\n--- Stack Demo ---");
  let stack = [];

  console.time("Push Operations (O(1))");
  stack.push(1);
  stack.push(2);
  stack.push(3);
  console.timeEnd("Push Operations (O(1))");
  console.log("Stack after pushes:", stack);

  console.time("Pop Operation (O(1))");
  let popped = stack.pop();
  console.timeEnd("Pop Operation (O(1))");
  console.log("Popped:", popped);
  console.log("Stack now:", stack);

  console.log("👉 Notice: Stack follows Last In, First Out (LIFO), like stacking plates.");
  console.log("--- End of Stack Demo ---\n");
}

// ========================
// Queue Demo
// ========================
function queueDemo() {
  console.log("\n--- Queue Demo ---");
  let queue = [];

  console.time("Enqueue Operations (O(1))");
  queue.push("A");
  queue.push("B");
  queue.push("C");
  console.timeEnd("Enqueue Operations (O(1))");
  console.log("Queue after enqueues:", queue);

  console.time("Dequeue Operation (O(n))");
  let removed = queue.shift();
  console.timeEnd("Dequeue Operation (O(n))");
  console.log("Dequeued:", removed);
  console.log("Queue now:", queue);

  console.log("👉 Notice: Queue follows First In, First Out (FIFO), like people in a waiting line.");
  console.log("👉 In JavaScript, removing from the front with shift() is O(n) because it shifts all elements.");
  console.log("--- End of Queue Demo ---\n");
}

// ========================
// Menu
// ========================
function showMenu() {
  console.log("================================");
  console.log(" Select a Data Structure Demo ");
  console.log("================================");
  console.log("1. Arrays");
  console.log("2. Linked List");
  console.log("3. Stack");
  console.log("4. Queue");
  console.log("5. Exit");
  console.log("================================");

  rl.question("Enter choice: ", (choice) => {
    switch (choice) {
      case "1":
        arrayDemo();
        break;
      case "2":
        linkedListDemo();
        break;
      case "3":
        stackDemo();
        break;
      case "4":
        queueDemo();
        break;
      case "5":
        console.log("Exiting...");
        rl.close();
        return;
      default:
        console.log("Invalid choice, try again.");
    }
    showMenu(); // loop back after running
  });
}

showMenu();
