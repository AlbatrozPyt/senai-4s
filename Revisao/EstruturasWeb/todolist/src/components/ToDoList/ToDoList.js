import { useEffect, useState } from "react"
import "./style.css"
import { ToDo } from "../ToDo/ToDo"
import moment from "moment"
import { tz } from "moment-timezone"

export const ToDoList = ({ data = [], setArray, setIndex, setMode, setModalUpdate, setComplete }) => {

    const [search, setSearch] = useState("")
    const [arraySearch, setArraySearch] = useState([])
    const [date, setDate] = useState("")

    const [month, setMonth] = useState("")
    const [week, setWeek] = useState("")

    const months = [
        "Janeiro",
        "Fevereiro",
        "Março",
        "Abril",
        "Maio",
        "Junho",
        "Julho",
        "Agosto",
        "Setembro",
        "Outubro",
        "Novembro",
        "Dezembro"
    ]

    const weeks = [
        "Segunda-Feira",
        "Terça-Feira",
        "Quarta-Feira",
        "Quinta-Feira",
        "Sexta-Feira"
    ]

    useEffect(() => {
        if (search !== "") {
            const newData = data.filter(x => x.description == search)
            setArraySearch(newData)
        }
        else {
            setArraySearch(data)
        }
        
        months.forEach((x, index) => {
            if ((moment().tz("America/Sao_Paulo").month()) === index) {
                setMonth(x)
            }
        });

        weeks.forEach((x, index) => {
            if ((moment().tz("America/Sao_Paulo").weekday()) === index + 1) {
                setWeek(x)
            }
        });

    }, [search])

    return (
        <section className="todo">
            <h1>{week}, <span style={{color: "#8758ff"}}>{moment().tz("America/Sao_Paulo").date()}</span> de {month}</h1>

            <input className="search" placeholder="Procurar tarefa" onChange={e => setSearch(e.target.value)} />

            {
                arraySearch.map((x, index) => {
                    return (
                        <ToDo
                            obj={x}
                            index={index}
                            setIndex={setIndex}
                            setMode={setMode}
                            setModalUpdate={setModalUpdate}
                            setComplete={setComplete}
                        />
                    )
                })
            }
        </section>
    )
}