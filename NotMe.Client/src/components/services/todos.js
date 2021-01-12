import { ActionCreators } from '../actions/todoReducer';
import * as axios from 'axios';

const axiosInstance = axios.create({
    baseURL: 'https://localhost:5001/todo',
})

export const GetTodos = async (dispatch) => {
    try {
        // api call
        const { data } = await axiosInstance.get();
        dispatch(ActionCreators.setTodos(data));
    } catch {
        console.log('Error!');
    }
}

export const DeleteTodo = async (dispatch, todo) => {
    try {
        // api call
        await axiosInstance.delete(`/${todo.id}`);
        dispatch(ActionCreators.deleteNote(todo));
    } catch {
        console.log('Error!');
    }
}

export const NewTodo = async (dispatch, todo) => {
    try {
        // api call
        const { data } = await axiosInstance.post('', todo)
        dispatch(ActionCreators.newNote(data));
    } catch {
        console.log('Error!');
    }
}

export const EditTodo = async (dispatch, todo) => {
    try {
        // api call
        await axiosInstance.put('', todo);
        dispatch(ActionCreators.editNote(todo));
    } catch {
        console.log('Error!');
    }
}