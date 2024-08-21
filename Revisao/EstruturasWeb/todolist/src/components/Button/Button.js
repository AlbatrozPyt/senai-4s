import "./style.css"

export const Button = ({btnTitle, fn, disabled = false}) => {
    return (
        <button className="new-task" disabled={disabled} onClick={fn}>
            {btnTitle}
        </button>
    )
}