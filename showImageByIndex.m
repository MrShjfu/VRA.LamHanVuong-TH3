function Image = showImageByIndex(dataImage,dataLabel, index)
    allImages = loadMNISTImages(dataImage);
    allLabels = loadMNISTLabels(dataLabel);
    TotalImage = size(allImages,2);
    figure;
    if(index <= TotalImage)
        img = allImages(:, index);
        img = reshape(img,28,28);
        Image = imshow(img);
    end
end 