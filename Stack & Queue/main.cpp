#include <iostream>
#include <stdexcept>
using namespace std;

template <typename T>
class Node 
{
public:
    T data;
    Node<T>* next;

    Node(T data) 
    {
        this->data = data;
        this->next = nullptr;
    }
};

template <typename T>
class Stack 
{
private:
    Node<T>* top;

public:
    Stack() 
    {
        top = nullptr;
    }

    ~Stack() 
    {
        while (!isEmpty()) 
        {
            pop();
        }
    }

    void push(T data) 
    {
        Node<T>* newNode = new Node<T>(data);
        newNode->next = top;
        top = newNode;
    }

    T pop() 
    {
        if (isEmpty()) 
        {
            throw out_of_range("Stack is empty");
        }
        Node<T>* temp = top;
        T data = top->data;
        top = top->next;
        delete temp;
        return data;
    }

    T peek() 
    {
        if (isEmpty()) 
        {
            throw out_of_range("Stack is empty");
        }
        return top->data;
    }

    bool isEmpty() 
    {
        return top == nullptr;
    }
};

template <typename T>
class DoubleNode 
{
public:
    T data;
    DoubleNode<T>* next;
    DoubleNode<T>* prev;

    DoubleNode(T data) 
    {
        this->data = data;
        this->next = nullptr;
        this->prev = nullptr;
    }
};

template <typename T>
class Queue 
{
private:
    DoubleNode<T>* head;
    DoubleNode<T>* tail;

public:
    Queue() 
    {
        head = nullptr;
        tail = nullptr;
    }

    ~Queue() 
    {
        while (!isEmpty()) 
        {
            dequeue();
        }
    }

    void enqueue(T data) 
    {
        DoubleNode<T>* newNode = new DoubleNode<T>(data);
        if (isEmpty()) 
        {
            head = tail = newNode;
        }
        else 
        {
            tail->next = newNode;
            newNode->prev = tail;
            tail = newNode;
        }
    }

    T dequeue() 
    {
        if (isEmpty()) 
        {
            throw out_of_range("Queue is empty");
        }
        DoubleNode<T>* temp = head;
        T data = head->data;
        head = head->next;
        if (head != nullptr) 
        {
            head->prev = nullptr;
        }
        else 
        {
            tail = nullptr;
        }
        delete temp;
        return data;
    }

    T peek() 
    {
        if (isEmpty()) 
        {
            throw out_of_range("Queue is empty");
        }
        return head->data;
    }

    bool isEmpty() 
    {
        return head == nullptr;
    }
};

int main() 
{
    Stack<int> stack;
    stack.push(10);
    stack.push(20);
    stack.push(30);

    cout << "Stack top: " << stack.peek() << endl;
    cout << "Stack pop: " << stack.pop() << endl;
    cout << "Stack top: " << stack.peek() << endl;

    Queue<int> queue;
    queue.enqueue(10);
    queue.enqueue(20);
    queue.enqueue(30);

    cout << "Queue front: " << queue.peek() << endl;
    cout << "Queue dequeue: " << queue.dequeue() << endl;
    cout << "Queue front: " << queue.peek() << endl;

    return 0;
}
