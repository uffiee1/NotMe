import React, { useState, useEffect } from 'react';
import { useDispatch } from 'react-redux';
import { Form, Modal, Button, InputGroup, FormControl } from "react-bootstrap";
import { NewTodo, EditTodo } from '../../services/todos';

export const NewTodoModal = () => {
    const [show, setShow] = useState(false);
    const handleClose = () => setShow(false);
    const handleShow = () => setShow(true);

    return <div>
        <Button onClick={handleShow} className='btn btn-success'>New Todo</Button>
        <TodoModal todo={null} handleFormSubmit={NewTodo} show={show} handleClose={handleClose} />
    </div>
}

export const EditTodoModal = ({ todo }) => {
    const [show, setShow] = useState(false);
    const handleClose = () => setShow(false);
    const handleShow = () => setShow(true);

    return <div>
        <Button onClick={handleShow} className='btn btn-warning'>Edit</Button>
        <TodoModal todo={todo} handleFormSubmit={EditTodo} show={show} handleClose={handleClose} />
    </div>
}

const TodoModal = ({ todo, handleFormSubmit, show, handleClose }) => {
    const [modalTodo, setModalTodo] = useState({});
    const dispatch = useDispatch();

    useEffect(() => {
        setModalTodo(todo);
    }, [todo]);

    return (
        <Modal show={show} onHide={handleClose}>
            <Modal.Header closeButton>
                <Modal.Title>Modal heading</Modal.Title>
            </Modal.Header>
            <Form onSubmit={event => {
                event.preventDefault();
                handleFormSubmit(dispatch, modalTodo);
            }}>
                <Modal.Body>
                    <InputGroup>
                        <FormControl value={modalTodo === null ? '' : modalTodo.value}
                            onChange={event => setModalTodo({ ...modalTodo, value: event.target.value })} />
                    </InputGroup>
                </Modal.Body>
                <Modal.Footer>
                    <Button variant="secondary" onClick={handleClose}>
                        Close
            </Button>
                    <Button type='submit' variant="primary" onClick={handleClose}>
                        Save
            </Button>
                </Modal.Footer>
            </Form>
        </Modal>
    );
}