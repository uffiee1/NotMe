﻿import React, { Component } from 'react';

export class Todo extends Component {
    static displayName = Todo.name;
    constructor(props) {
        super(props);
        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
        this.state = {
            items: [],
            text: ''
        };
    }

    handleChange(e) {
        this.setState({text : e.target.value});
    }
  
    handleSubmit(e) {
        e.preventDefault();
        var newItem = {
            text: this.state.text,
            id: Date.now()
        };
        this.setState((prevState) => ({
            items: prevState.items.concat(newItem),
            text: ''      
        }));
    }

    render() {
        return (
            <div>
            <h1>TODO TEST</h1>
            <TodoList items={this.state.items} />
            <form onSubmit={this.handleSubmit}>
            <input onChange={this.handleChange} value={this.state.text} />
            <button>Add</button>
            </form>
            </div>
    );
}
}

class TodoList extends React.Component {
    render() {
        return (
            <ul>
            {this.props.items.map(item => 
                (<li key={item.id}>{item.text}</li>))}
</ul>
)
};
}