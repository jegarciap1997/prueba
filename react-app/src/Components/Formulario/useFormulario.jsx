import { useEffect, useState } from "react"
import { useServicio } from "../../Hooks/useServicio"

function useFormulario() {

    const { response, error, consumirServicio, limpiarEstados } = useServicio()
    const [cargando, setCargando] = useState(false)
    const [data, setData] = useState(null)


    useEffect(() => {

        setCargando(true)
        consumirServicio()

    }, [])

    if (response) {

        setCargando(false)
        limpiarEstados()

        if (response.status === 200)
            setData(response.data)

    }

    if (error) {

        setCargando(false)
        limpiarEstados()
        console.log("🚀 ~ useFormulario ~ error:", error)

    }

    return {
        cargando,
        data
    }

}

export { useFormulario }
