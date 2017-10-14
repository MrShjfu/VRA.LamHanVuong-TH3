function showImageAndLabelByIndex(data, index)
    fprintf('Load data');
    allImage = loadMNISTImages(data);
    TotalImage = size(allImage,2);
    figure;
    if(index <= TotalImage)
        img = allImage(:, index);
        img = reshape(img,28,28)
        index = num2str(index);
        imshow(img);
        title(index);
    end
end 