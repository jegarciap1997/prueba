import { createBrowserRouter, RouterProvider } from "react-router-dom"
import { Formulario } from "./Components/Formulario/Formulario"

function App() {

  const router = createBrowserRouter([
    {
      path: '/',
      element: <Formulario />
    },
  ])

  return (
    <RouterProvider router={router} />
  )
}

export default App
