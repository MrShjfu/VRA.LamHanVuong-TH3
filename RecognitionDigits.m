function strLabelImage = RecognitionDigits(index)
    imgTrainAll = loadMNISTImages('train-images.idx3-ubyte');
    lblTrainAll = loadMNISTLabels('train-labels.idx1-ubyte');
    
    Mdl = fitcknn(imgTrainAll', lblTrainAll);
    imgTestAll = loadMNISTImages('t10k-images.idx3-ubyte');
    lblTestAll = loadMNISTLabels('t10k-labels.idx1-ubyte');
    
    mTestImgs = size(imgTestAll,2 );
    nNumber =index;
    imgTest = imgTestAll(:,nNumber);
    lblPredictTest = predict(Mdl, imgTest');
    lblImageTest = lblTestAll(nNumber);
    figure;
    img2D = reshape (imgTest,28,28);
    imshow(img2D);
    strLabelImage = 'Ban Dau ';
    strLabelImage = [strLabelImage, num2str(lblTestAll(nNumber)),'.'];
    strLabelImage = [strLabelImage, ' Du doan: '];
    strLabelImage = [strLabelImage, num2str(lblPredictTest), '.'];
    if(lblPredictTest == lblImageTest)
        strLabelImage = [strLabelImage, 'Ket qua dung.'];
    else
        strLabelImage = [strLabelImage, 'ket qua sai '];
    end
    title(strLabelImage)
end