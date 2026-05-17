window.showImagePreview = (inputFile, tagImage) => {

    const imageURL = URL.createObjectURL(inputFile.files[0]);
    tagImage.addEventListener('load', () => URL.revokeObjectURL(imageURL), { once: true });
    tagImage.src = imageURL;

}