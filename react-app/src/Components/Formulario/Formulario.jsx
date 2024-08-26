import { useFormulario } from "./useFormulario"
import { Loader } from '../Loader/Loader'
import { Campos } from "../Campos/Campos"

function Formulario() {

    const { cargando, data } = useFormulario()

    return (
        <section className="row">

            {cargando && <Loader />}
            {data && <Campos data={data} />}

        </section>
    )

}

export { Formulario }
