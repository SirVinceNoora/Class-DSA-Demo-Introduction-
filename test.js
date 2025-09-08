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

  console.time("Access First Element");
  console.log("1) First element (O(1)):", arr[0]);
  console.timeEnd("Access First Element");

  console.time("Unshift Operation");
  arr.unshift(5); // O(n)
  console.log("2) After unshift (insert at start):", arr);
  console.timeEnd("Unshift Operation");

  console.time("Splice Operation");
  arr.splice(2, 1); // O(n)
  console.log("3) After deleting index 2:", arr);
  console.timeEnd("Splice Operation");

  console.log("--- End of Array Demo ---\n");
}


function linkedListDemo() {
  console.log("\n--- Linked List Demo ---");
  class Node {
    constructor(data) { 5
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
      while (temp.next) {
        temp = temp.next;
      }
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

  console.time("LinkedList Operations");
  const ll = new LinkedList();
  ll.append(10);
  ll.append(20);
  ll.append(30);
  ll.display();
  console.timeEnd("LinkedList Operations");

  console.log("--- End of Linked List Demo ---\n");
}

// ========================
// Stack Demo
// ========================
function stackDemo() {
  console.log("\n--- Stack Demo ---");
  let stack = [];

  console.time("Push Operations");
  stack.push(1);
  stack.push(2);
  stack.push(3);
  console.timeEnd("Push Operations");

  console.time("Pop Operation");
  console.log("Popped:", stack.pop());
  console.timeEnd("Pop Operation");

  console.log("Stack now:", stack);
  console.log("--- End of Stack Demo ---\n");
}

// ========================
// Queue Demo
// ========================
function queueDemo() {
  console.log("\n--- Queue Demo ---");
  let queue = [];

  console.time("Enqueue Operations");
  queue.push("A");
  queue.push("B");
  queue.push("C");
  console.timeEnd("Enqueue Operations");

  console.time("Dequeue Operation");
  console.log("Dequeued:", queue.shift());
  console.timeEnd("Dequeue Operation");

  console.log("Queue now:", queue);
  console.log("--- End of Queue Demo ---\n");
}

// ========================
// Menu
// ========================
function showMenu() {
  console.log("Select a demo to run:");
  console.log("1. Arrays");
  console.log("2. Linked List");
  console.log("3. Stack");
  console.log("4. Queue");
  console.log("5. Exit");

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
