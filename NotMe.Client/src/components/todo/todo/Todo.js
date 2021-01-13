import React, { Component } from 'react';
import { NewTodoModal } from './TodoModal';
import { TodosTable } from './TodoTable';
import './Todo.css';

export class Todo extends Component {
    static displayName = Todo.name;

    render() {
        return (
            <div>
                <h1>TODO LIST FOR USER</h1>
                <div style={{ maxWidth: '70%', margin: 'auto' }}>
                    <div style={{ textAlign: 'right' }}>
                        <NewTodoModal />
                    </div>
                    <TodosTable />
                </div>
            </div>
        );
    }
}