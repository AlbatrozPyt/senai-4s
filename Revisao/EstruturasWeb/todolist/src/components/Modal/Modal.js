import { useState } from "react"
import { Button } from "../Button/Button"
import "./style.css"

export const Modal = ({ fn, setValue, value, titleModal, setVisible }) => {

    return (
        <div className="background-modal">
            <div className="box-modal">
                <h2>{titleModal}</h2>

                <textarea onChange={(e) => setValue(e.target.value)}>
                </textarea>

                <Button
                    disabled={value === ""}
                    fn={fn}
                    btnTitle={'Confirmar tarefa'}
                />

                <button className="new-task" onClick={() => setVisible(false)}>Cancelar</button>
            </div>
        </div>
    )
}