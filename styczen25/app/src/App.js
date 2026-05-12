import logo from './logo.svg';
import './App.css';
import 'bootstrap/dist/css/bootstrap.css';
import { useState } from 'react';

const imagesInit = [{ id: 0, alt: "Mak", filename: "obraz1.jpg", category: 1, downloads: 35 },
{ id: 1, alt: "Bukiet", filename: "obraz2.jpg", category: 1, downloads: 43 },
{ id: 2, alt: "Dalmatyńczyk", filename: "obraz3.jpg", category: 2, downloads: 2 },
{ id: 3, alt: "Świnka morska", filename: "obraz4.jpg", category: 2, downloads: 53 },
{ id: 4, alt: "Rotwailer", filename: "obraz5.jpg", category: 2, downloads: 43 },
{ id: 5, alt: "Audi", filename: "obraz6.jpg", category: 3, downloads: 11 },
{ id: 6, alt: "kotki", filename: "obraz7.jpg", category: 2, downloads: 22 },
{ id: 7, alt: "Róża", filename: "obraz8.jpg", category: 1, downloads: 33 },
{ id: 8, alt: "Świnka morska", filename: "obraz9.jpg", category: 2, downloads: 123 },
{ id: 9, alt: "Foksterier", filename: "obraz10.jpg", category: 2, downloads: 22 },
{ id: 10, alt: "Szczeniak", filename: "obraz11.jpg", category: 2, downloads: 12 },
{ id: 11, alt: "Garbus", filename: "obraz12.jpg", category: 3, downloads: 321 }]

function App() {
  let [flowersVisible, setFlowersVisible] = useState(true);
  let [animalsVisible, setAnimalsVisible] = useState(true);
  let [carsVisible, setCarsVisible] = useState(true);
  let [images, setImages] = useState(imagesInit);

  return (
    <div className="App" class="">
      <h1>Kategorie zdjęć</h1>
      
      <div class="form-check form-switch d-inline-block">
        <input type="checkbox" checked={flowersVisible} onClick={() => setFlowersVisible(!flowersVisible)} id="flowers" class="form-check-input" />
        <label for="flowers" class="form-check-label" >Kwiaty</label>
      </div>

      <div class="form-check form-switch d-inline-block">
        <input type="checkbox" checked={animalsVisible} onClick={() => setAnimalsVisible(!animalsVisible)} id="animals" class="form-check-input" />
        <label for="animals" class="form-check-label" >Zwierzęta</label>
      </div>
      
      <div class="form-check form-switch d-inline-block">
        <input type="checkbox" checked={carsVisible} onClick={() => setCarsVisible(!carsVisible)} id="cars" class="form-check-input" />
        <label for="cars" class="form-check-label" >Samochody</label>
      </div><br></br>

      {images.map(image => {
        const downloadButton = () => {
          setImages(images.map(img => { if (img.id === image.id) img.downloads++; return img }));
        }

        if ((image.category === 1 && flowersVisible) || (image.category === 2 && animalsVisible) || (image.category === 3 && carsVisible)) {
          return <div class="d-inline-block p5">
            <img id={image.id} src={"./assets/" + image.filename} alt={image.alt} class="rounded"/><br/>
            <h4>Pobrań: {image.downloads}</h4><br/>
            <button onClick={downloadButton} class="btn btn-success">Pobierz</button>
          </div>
        }
        else return <></>
      })}
    </div>
  );
}

export default App;
