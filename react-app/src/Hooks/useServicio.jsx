import { useState } from "react"
import axios from "axios"

function useServicio() {

    const [response, setResponse] = useState(null)
    const [error, setError] = useState(null)

    const urlRoute = import.meta.env.VITE_URL_ROUTER

    const consumirServicio = () => {

        axios.get(`${urlRoute}/7c033695-a247-4c07-a5ff-484598745462`)
            .then(response => setResponse(response))
            .catch(error => setError(error))

    }

    const limpiarEstados = () => {

        setResponse(null)
        setError(null)

    }

    return {
        response,
        error,
        consumirServicio,
        limpiarEstados
    }

}

export { useServicio }
