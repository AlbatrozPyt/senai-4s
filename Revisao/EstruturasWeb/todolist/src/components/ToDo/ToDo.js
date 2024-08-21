import { useEffect, useState } from "react";
import { Modal } from "../Modal/Modal";
import editPen from "../../assets/img/edit.svg";
import close from "../../assets/img/close.svg";
import "./style.css";

export const ToDo = ({
    obj,
    index,
    setIndex,
    setMode,
    setModalUpdate,
    setComplete
}) => {

    return (
        <div style={obj.status ? {backgroundColor: '#6c45ce'} : {backgroundColor: '#fcfcfc'}} className="box-todo">
            <input
                type="checkbox"
                checked={obj.status}
                onChange={() => {
                    setComplete(true)
                    setIndex(index)
                }}
            />

            <p style={!obj.status ? {color: '#1e123b'} : {color: '#fcfcfc'}}>{obj.description}</p>

            <div className="icons">
                <button onClick={() => {
                    setIndex(index)
                    setMode("editar")
                    setModalUpdate(true)
                }}
                >
                    <img src={editPen} alt="editar" />
                </button>

                <button onClick={() => {
                    setIndex(index)
                    setMode("deletar")
                }}>
                    <img src={close} alt="deletar" />
                </button>
            </div>

            {/* {
                modal && <Modal fn={updateToDo(index)} setValue={setValue} value={value} />
            } */}

        </div>
    )
}