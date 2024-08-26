function Campos({ data }) {

    const style = {
        height: '100vh',
        width: '100vw'
    }

    return (
        <div style={style} className="d-flex flex-column justify-content-center align-items-center p-5">
            <div className="card shadow-sm p-3 mb-5 bg-body-tertiary rounded" style={{ width: '800px' }}>
                <div className="text-center">
                    <img src={data['background_image']} width='600' className="img-fluid my-3" alt={data['name']} />
                </div>
                <div className="card-body">
                    <h5 className="card-title">{data['name']}</h5>
                    <strong>Created At: </strong><span className="card-text">{data['created_at']}</span>
                </div>
                <div className="accordion" id="Genres">
                    <div className="accordion-item">
                        <h2 className="accordion-header">
                            <button className="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
                                Genres
                            </button>
                        </h2>
                        <div id="collapseOne" className="accordion-collapse collapse" data-bs-parent="#Genres">
                            <div className="accordion-body">
                                <ul className="list-group list-group-flush">
                                    {
                                        data?.['genres'].length > 0 && data?.['genres'].map((genre, index) => (
                                            <li key={index} className="list-group-item">{genre['name']}</li>
                                        ))
                                    }
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
                <div className="accordion" id="Platforms">
                    <div className="accordion-item">
                        <h2 className="accordion-header">
                            <button className="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseTwo" aria-expanded="true" aria-controls="collapseOne">
                                Platforms
                            </button>
                        </h2>
                        <div id="collapseTwo" className="accordion-collapse collapse" data-bs-parent="#Platforms">
                            <div className="accordion-body">
                                <ul className="list-group list-group-flush">
                                    {
                                        data?.['platforms'].length > 0 && data?.['platforms'].map((genre, index) => (
                                            <li key={index} className="list-group-item">{genre['name']}</li>
                                        ))
                                    }
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
                <div className="card-body">
                    <table className="table table-striped">
                        <thead>
                            <tr>
                                <th>Item</th>
                                <th>Valor</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>
                                    Rating
                                </td>
                                <td>
                                    <span>{data['rating']}</span>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Rating Top
                                </td>
                                <td>
                                    <span>{data['rating_top']}</span>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Ratings Count
                                </td>
                                <td>
                                    <span>{data['ratings_count']}</span>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Released
                                </td>
                                <td>
                                    <span>{data['released']}</span>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Reviews Count
                                </td>
                                <td>
                                    <span>{data['reviews_count']}</span>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Slug
                                </td>
                                <td>
                                    <span>{data['slug']}</span>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Updated At
                                </td>
                                <td>
                                    <span>{data['updated_at']}</span>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    )

}

export { Campos }
