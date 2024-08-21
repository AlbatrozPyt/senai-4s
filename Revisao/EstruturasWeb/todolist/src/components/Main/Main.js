import { useEffect, useState } from "react"
import { Button } from "../Button/Button"
import { ToDoList } from "../ToDoList/ToDoList"
import "./style.css"
import { Modal } from "../Modal/Modal"

export const Main = () => {

    const [array, setArray] = useState([]);
    const [value, setValue] = useState("");

    const [modal, setModal] = useState(false)
    const [modalUpdate, setModalUpdate] = useState(false)
    const [complete, setComplete] = useState(false)
    const [index, setIndex] = useState(false)
    const [mode, setMode] = useState("")

    function addToDo() {
        array.push({ status: false, description: value })
        setValue("")
        setModal(false)
    }

    function deleteToDo() {
        array.forEach((x, i) => {
            if (i === index) {
                array.splice(index, 1)
            }
        });

        setIndex(false)
    }

    function updateToDo() {
        array.forEach((x, i) => {
            if (index === i) {
                x.description = value
            }
        });

        setIndex(false)
        setModalUpdate(false)
    }

    function setStatus() {
        array.forEach((x, i) => {
            if (index === i) {
                x.status ? x.status = false : x.status = true
            }
        });

        setIndex(false)
        setComplete(false)
    }

    useEffect(() => {
        if (index !== false && mode !== "editar" && !complete) {
            deleteToDo()
        }

        if (complete) {
            setStatus()
        }

        console.log(array)

    }, [array.length, index, complete])


    return (
        <main>
            <ToDoList
                data={array}
                setArray={setArray}
                setIndex={setIndex}
                setMode={setMode}
                setModalUpdate={setModalUpdate}
                setComplete={setComplete}
            />

            <Button fn={() => setModal(true)} btnTitle={'Nova tarefa'} />

            {
                modal && <Modal titleModal={'Descreva sua tarefa'} setValue={setValue} fn={addToDo} value={value} />
            }

            {
                modalUpdate && <Modal titleModal={'Editar sua tarefa'} setValue={setValue} fn={updateToDo}  value={value} />
            }
        </main>
    )
}