function Image = ShowSimilarImage(index)
    imgTrainAll = loadMNISTImages('train-images.idx3-ubyte');
    lblTrainAll = loadMNISTLabels('train-labels.idx1-ubyte');
    
    Mdl = fitcknn(imgTrainAll', lblTrainAll);
    imgTestAll = loadMNISTImages('t10k-images.idx3-ubyte');
    lblTestAll = loadMNISTLabels('t10k-labels.idx1-ubyte');
    mTestImgs = size(imgTestAll,2 );
    nNumber =index;
    imageInput = imgTestAll(:, index);
    imageInput = reshape(imageInput,[28,28]);
    imgTest = imgTestAll(:,nNumber);
    lblPredictTest = predict(Mdl, imgTest');
    figure;
    indexSimilarImage = find(lblTrainAll==lblPredictTest);
    
    
    value = 1;
    lstImage=zeros(0,0,'double');
    for i = 1: 4
       	lst = imgTrainAll(:, indexSimilarImage(value));
        lst = reshape(lst,[28,28]);
        value= value +1;
        for j = 1:10
            img = imgTrainAll(:, indexSimilarImage(value));
            img = reshape(img,[28,28]);
            lst = cat(2,lst,img);
            value =value +1;

        end
        lstImage = cat(1,lst,lstImage);
    end

    subplot(1,2,1), imshow(imageInput); title('Anh Dau Vao');
    subplot(1,2,2), imshow(lstImage); title('Anh lien quan');       	
end