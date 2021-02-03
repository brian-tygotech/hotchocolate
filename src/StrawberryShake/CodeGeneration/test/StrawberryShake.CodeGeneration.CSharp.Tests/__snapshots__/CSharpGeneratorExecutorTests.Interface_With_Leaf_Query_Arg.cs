﻿// DroidEntity

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class DroidEntity
    {
        public global::StrawberryShake.EntityId Id { get; }

        public global::System.String Name { get; set; }

        public global::System.Collections.Generic.IReadOnlyList<Episode?>? AppearsIn { get; set; }
    }
}


// HumanEntity

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class HumanEntity
    {
        public global::StrawberryShake.EntityId Id { get; }

        public global::System.String Name { get; set; }

        public global::System.Collections.Generic.IReadOnlyList<Episode?>? AppearsIn { get; set; }
    }
}


// Episode

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public enum Episode
    {
        NewHope,
        Empire,
        Jedi
    }
}


// Episode

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class EpisodeParser
    {
        private Episode Parse(global::System.String serializedValue)
        {
            return serializedValue switch
            {
                "NEW_HOPE" => Episode.NewHope,
                "EMPIRE" => Episode.Empire,
                "JEDI" => Episode.Jedi,
                _ => throw new global::StrawberryShake.GraphQLClientException()
            };
        }

        public object Format(object runtimeValue)
        {
            return runtimeValue switch
            {
                Episode.NewHope => "NEW_HOPE",
                Episode.Empire => "EMPIRE",
                Episode.Jedi => "JEDI",
                _ => throw new global::StrawberryShake.GraphQLClientException()
            };
        }
    }
}


// GetHero

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetHeroFactory
        : global::StrawberryShake.IOperationResultDataFactory<GetHero>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<DroidEntity, GetHero_Hero_Droid> _getHero_Hero_DroidFromDroidEntityMapper;
        private readonly global::StrawberryShake.IEntityMapper<HumanEntity, GetHero_Hero_Human> _getHero_Hero_HumanFromHumanEntityMapper;

        public GetHeroFactory(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityMapper<DroidEntity, GetHero_Hero_Droid> getHero_Hero_DroidFromDroidEntityMapper,
            global::StrawberryShake.IEntityMapper<HumanEntity, GetHero_Hero_Human> getHero_Hero_HumanFromHumanEntityMapper)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _getHero_Hero_DroidFromDroidEntityMapper = getHero_Hero_DroidFromDroidEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getHero_Hero_DroidFromDroidEntityMapper));
            _getHero_Hero_HumanFromHumanEntityMapper = getHero_Hero_HumanFromHumanEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getHero_Hero_HumanFromHumanEntityMapper));
        }

        public GetHero Create(global::StrawberryShake.IOperationResultDataInfo dataInfo)
        {
            if (dataInfo is GetHeroInfo info)
            {
                IGetHero_Hero hero = default!;

                var heroInfo = info.Hero ?? throw new global::System.ArgumentNullException();
                if (heroInfo.Name.Equals(
                    "Droid",
                    global::System.StringComparison.Ordinal
                ))
                {
                    hero = _getHero_Hero_DroidFromDroidEntityMapper.Map(_entityStore.GetEntity<DroidEntity>(heroInfo) ?? throw new global::System.ArgumentNullException());
                }

                if (heroInfo.Name.Equals(
                    "Human",
                    global::System.StringComparison.Ordinal
                ))
                {
                    hero = _getHero_Hero_HumanFromHumanEntityMapper.Map(_entityStore.GetEntity<HumanEntity>(heroInfo) ?? throw new global::System.ArgumentNullException());
                }

                return new GetHero(hero);
            }

            throw new global::System.ArgumentException("GetHeroInfo expected.");
        }
    }
}


// GetHero

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetHeroInfo
        : global::StrawberryShake.IOperationResultDataInfo
    {
        private readonly global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> _entityIds;
        private readonly ulong _version;

        public GetHeroInfo(
            global::StrawberryShake.EntityId? hero,
            global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> entityIds,
            ulong version)
        {
            Hero = hero;
            _entityIds = entityIds
                 ?? throw new global::System.ArgumentNullException(nameof(entityIds));
            _version = version;
        }

        public global::StrawberryShake.EntityId? Hero { get; }

        public global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> EntityIds => _entityIds;

        public ulong Version => _version;

        public global::StrawberryShake.IOperationResultDataInfo WithVersion(ulong version)
        {
            return new GetHeroInfo(
                Hero,
                _entityIds,
                _version
            );
        }
    }
}


// GetHero

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetHero
        : IGetHero
    {
        public GetHero(IGetHero_Hero? hero)
        {
            Hero = hero;
        }

        public IGetHero_Hero? Hero { get; }
    }
}


// GetHero_Hero_Droid

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetHero_Hero_DroidFromDroidEntityMapper
        : global::StrawberryShake.IEntityMapper<DroidEntity, GetHero_Hero_Droid>
    {
        public GetHero_Hero_Droid Map(DroidEntity entity)
        {
            return new GetHero_Hero_Droid(
                entity.Name,
                entity.AppearsIn
            );
        }
    }
}


// GetHero_Hero_Droid

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetHero_Hero_Droid
        : IGetHero_Hero
    {
        public GetHero_Hero_Droid(
            global::System.String name,
            global::System.Collections.Generic.IReadOnlyList<Episode?>? appearsIn)
        {
            Name = name;
            AppearsIn = appearsIn;
        }

        public global::System.String Name { get; }

        public global::System.Collections.Generic.IReadOnlyList<Episode?>? AppearsIn { get; }
    }
}


// GetHero_Hero_Human

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetHero_Hero_HumanFromHumanEntityMapper
        : global::StrawberryShake.IEntityMapper<HumanEntity, GetHero_Hero_Human>
    {
        public GetHero_Hero_Human Map(HumanEntity entity)
        {
            return new GetHero_Hero_Human(
                entity.Name,
                entity.AppearsIn
            );
        }
    }
}


// GetHero_Hero_Human

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetHero_Hero_Human
        : IGetHero_Hero
    {
        public GetHero_Hero_Human(
            global::System.String name,
            global::System.Collections.Generic.IReadOnlyList<Episode?>? appearsIn)
        {
            Name = name;
            AppearsIn = appearsIn;
        }

        public global::System.String Name { get; }

        public global::System.Collections.Generic.IReadOnlyList<Episode?>? AppearsIn { get; }
    }
}


// IGetHero

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface IGetHero
    {
        public IGetHero_Hero? Hero { get; }
    }
}


// IGetHero_Hero

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface IGetHero_Hero
    {
        public global::System.String Name { get; }

        public global::System.Collections.Generic.IReadOnlyList<Episode?>? AppearsIn { get; }
    }
}


// CreateReview

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class CreateReviewFactory
        : global::StrawberryShake.IOperationResultDataFactory<CreateReview>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<ReviewEntity, CreateReview_CreateReview> _createReview_CreateReviewFromReviewEntityMapper;

        public CreateReviewFactory(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityMapper<ReviewEntity, CreateReview_CreateReview> createReview_CreateReviewFromReviewEntityMapper)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _createReview_CreateReviewFromReviewEntityMapper = createReview_CreateReviewFromReviewEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(createReview_CreateReviewFromReviewEntityMapper));
        }

        public CreateReview Create(global::StrawberryShake.IOperationResultDataInfo dataInfo)
        {
            if (dataInfo is CreateReviewInfo info)
            {
                ICreateReview_CreateReview createReview = default!;

                var createReviewInfo = info.CreateReview ?? throw new global::System.ArgumentNullException();
                if (createReviewInfo.Name.Equals(
                    "Review",
                    global::System.StringComparison.Ordinal
                ))
                {
                    createReview = _createReview_CreateReviewFromReviewEntityMapper.Map(_entityStore.GetEntity<ReviewEntity>(createReviewInfo) ?? throw new global::System.ArgumentNullException());
                }

                return new CreateReview(createReview);
            }

            throw new global::System.ArgumentException("CreateReviewInfo expected.");
        }
    }
}


// CreateReview

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class CreateReviewInfo
        : global::StrawberryShake.IOperationResultDataInfo
    {
        private readonly global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> _entityIds;
        private readonly ulong _version;

        public CreateReviewInfo(
            ICreateReview_CreateReview createReview,
            global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> entityIds,
            ulong version)
        {
            CreateReview = createReview;
            _entityIds = entityIds
                 ?? throw new global::System.ArgumentNullException(nameof(entityIds));
            _version = version;
        }

        public ICreateReview_CreateReview CreateReview { get; }

        public global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> EntityIds => _entityIds;

        public ulong Version => _version;

        public global::StrawberryShake.IOperationResultDataInfo WithVersion(ulong version)
        {
            return new CreateReviewInfo(
                CreateReview,
                _entityIds,
                _version
            );
        }
    }
}


// CreateReview

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class CreateReview
        : ICreateReview
    {
        public CreateReview(ICreateReview_CreateReview createReview)
        {
            CreateReview = createReview;
        }

        public ICreateReview_CreateReview CreateReview { get; }
    }
}


// CreateReview_CreateReview

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class CreateReview_CreateReview
        : ICreateReview_CreateReview
    {
        public CreateReview_CreateReview(
            global::System.Int stars,
            global::System.String? commentary)
        {
            Stars = stars;
            Commentary = commentary;
        }

        public global::System.Int Stars { get; }

        public global::System.String? Commentary { get; }
    }
}


// ICreateReview

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface ICreateReview
    {
        public ICreateReview_CreateReview CreateReview { get; }
    }
}


// ICreateReview_CreateReview

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface ICreateReview_CreateReview
    {
        public global::System.Int Stars { get; }

        public global::System.String? Commentary { get; }
    }
}


// ReviewInput

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class ReviewInput
    {
        public global::System.Int Stars { get; set; }

        public global::System.String? Commentary { get; set; }
    }
}


// GetHeroQuery

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetHeroQueryDocument
        : global::StrawberryShake.IDocument
    {
        private const global::System.String _bodyString = 
            @"query GetHero($episode: Episode) {
  hero(episode: $episode) {
    name
    appearsIn
  }
}";
        private static readonly byte[] _body = global::System.Text.Encoding.UTF8.GetBytes(_bodyString);

        private GetHeroQueryDocument()
        {
        }

        public static GetHeroQueryDocument Instance { get; } = new GetHeroQueryDocument();

        public global::StrawberryShake.OperationKind Kind => global::StrawberryShake.OperationKind.Query;

        public global::System.ReadOnlySpan<byte> Body => _body;

        public override string ToString()
        {
            return _bodyString;
        }
    }
}


// GetHeroQuery

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetHeroQuery
    {
        private readonly global::StrawberryShake.IOperationExecutor<IGetHero> _operationExecutor;

        public GetHeroQuery(global::StrawberryShake.IOperationExecutor<IGetHero> operationExecutor)
        {
            _operationExecutor = operationExecutor
                 ?? throw new global::System.ArgumentNullException(nameof(operationExecutor));
        }

        public async global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IGetHero>> Execute(
            Episode? episode,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = CreateRequest(episode);
            
            return await _operationExecutor
                .ExecuteAsync(
                    request,
                    cancellationToken
                )
                .ConfigureAwait(false);
        }

        public global::System.IObservable<global::StrawberryShake.IOperationResult<IGetHero>> Watch(
            Episode? episode,
            global::StrawberryShake.ExecutionStrategy? strategy = null)
        {
            var request = CreateRequest(episode);
            return _operationExecutor.Watch(request, strategy);
        }

        private global::StrawberryShake.OperationRequest CreateRequest(Episode? episode)
        {
            var arguments = new global::System.Collections.Generic.Dictionary<string, object?>();
            arguments.Add("episode", episode);

            return new global::StrawberryShake.OperationRequest(
                "IGetHero",
                GetHeroQueryDocument.Instance,
                arguments
            );
        }
    }
}


// createReviewMutation

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class createReviewMutationDocument
        : global::StrawberryShake.IDocument
    {
        private const global::System.String _bodyString = 
            @"mutation createReview($episode: Episode!, $review: ReviewInput!) {
  createReview(episode: $episode, review: $review) {
    stars
    commentary
  }
}";
        private static readonly byte[] _body = global::System.Text.Encoding.UTF8.GetBytes(_bodyString);

        private createReviewMutationDocument()
        {
        }

        public static createReviewMutationDocument Instance { get; } = new createReviewMutationDocument();

        public global::StrawberryShake.OperationKind Kind => global::StrawberryShake.OperationKind.Mutation;

        public global::System.ReadOnlySpan<byte> Body => _body;

        public override string ToString()
        {
            return _bodyString;
        }
    }
}


// createReviewMutation

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class createReviewMutation
    {
        private readonly global::StrawberryShake.IOperationExecutor<ICreateReview> _operationExecutor;

        public createReviewMutation(global::StrawberryShake.IOperationExecutor<ICreateReview> operationExecutor)
        {
            _operationExecutor = operationExecutor
                 ?? throw new global::System.ArgumentNullException(nameof(operationExecutor));
        }

        public async global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<ICreateReview>> Execute(
            Episode? episode,
            ReviewInput? review,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = CreateRequest(
                episode,
                review
            );
            
            return await _operationExecutor
                .ExecuteAsync(
                    request,
                    cancellationToken
                )
                .ConfigureAwait(false);
        }

        public global::System.IObservable<global::StrawberryShake.IOperationResult<ICreateReview>> Watch(
            Episode? episode,
            ReviewInput? review,
            global::StrawberryShake.ExecutionStrategy? strategy = null)
        {
            var request = CreateRequest(
                episode,
                review
            );
            return _operationExecutor.Watch(request, strategy);
        }

        private global::StrawberryShake.OperationRequest CreateRequest(
            Episode? episode,
            ReviewInput? review)
        {
            var arguments = new global::System.Collections.Generic.Dictionary<string, object?>();
            arguments.Add("episode", episode);
            arguments.Add("review", review);

            return new global::StrawberryShake.OperationRequest(
                "ICreateReview",
                createReviewMutationDocument.Instance,
                arguments
            );
        }
    }
}


// GetHeroBuilder

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetHeroBuilder
        : global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, IGetHero>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::System.Func<global::System.Text.Json.JsonElement, global::StrawberryShake.EntityId> _extractId;
        private readonly global::StrawberryShake.IOperationResultDataFactory<IGetHero> _resultDataFactory;
        private global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, Episode> _episodeParser;
        private global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::System.String> _stringParser;

        public GetHeroBuilder(
            global::StrawberryShake.IEntityStore entityStore,
            global::System.Func<global::System.Text.Json.JsonElement, global::StrawberryShake.EntityId> extractId,
            global::StrawberryShake.IOperationResultDataFactory<IGetHero> resultDataFactory,
            global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _extractId = extractId
                 ?? throw new global::System.ArgumentNullException(nameof(extractId));
            _resultDataFactory = resultDataFactory
                 ?? throw new global::System.ArgumentNullException(nameof(resultDataFactory));
            _episodeParser = serializerResolver.GetLeafValueParser<global::System.String, Episode>("Episode")
                 ?? throw new global::System.ArgumentNullException(nameof(_episodeParser));
            _stringParser = serializerResolver.GetLeafValueParser<global::System.String, global::System.String>("String")
                 ?? throw new global::System.ArgumentNullException(nameof(_stringParser));
        }

        public global::StrawberryShake.IOperationResult<IGetHero> Build(global::StrawberryShake.Response<global::System.Text.Json.JsonDocument> response)
        {
            (IGetHero Result, GetHeroInfo Info)? data = null;

            if (response.Body is not null
                && response.Body.RootElement.TryGetProperty("data", out global::System.Text.Json.JsonElement obj))
            {
                data = BuildData(obj);
            }

            return new global::StrawberryShake.OperationResult<IGetHero>(
                data?.Result,
                data?.Info,
                _resultDataFactory,
                null
            );
        }

        private (IGetHero, GetHeroInfo) BuildData(global::System.Text.Json.JsonElement obj)
        {
            using global::StrawberryShake.IEntityUpdateSession session = _entityStore.BeginUpdate();
            var entityIds = new global::System.Collections.Generic.HashSet<global::StrawberryShake.EntityId>();

            global::StrawberryShake.EntityId? heroId = UpdateIGetHero_HeroEntity(
                global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(obj, "hero"),
                entityIds
            );

            var resultInfo = new GetHeroInfo(
                heroId,
                entityIds,
                session.Version
            );

            return (_resultDataFactory.Create(resultInfo), resultInfo);
        }

        private global::StrawberryShake.EntityId? UpdateIGetHero_HeroEntity(
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            global::StrawberryShake.EntityId entityId = _extractId(obj.Value);
            entityIds.Add(entityId);


            if (entityId.Name.Equals("GetHero_Hero_Droid", global::System.StringComparison.Ordinal))
            {
                DroidEntity entity = _entityStore.GetOrCreate<DroidEntity>(entityId);
                entity.Name = DeserializeNonNullableString(global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(obj.Value, "name"));
                entity.AppearsIn = DeserializeEpisodeArray(global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(obj.Value, "appearsIn"));

                return entityId;
            }

            if (entityId.Name.Equals("GetHero_Hero_Human", global::System.StringComparison.Ordinal))
            {
                HumanEntity entity = _entityStore.GetOrCreate<HumanEntity>(entityId);
                entity.Name = DeserializeNonNullableString(global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(obj.Value, "name"));
                entity.AppearsIn = DeserializeEpisodeArray(global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(obj.Value, "appearsIn"));

                return entityId;
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.String DeserializeNonNullableString(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _stringParser.Parse(obj.Value.GetString()!);
        }

        private global::System.Collections.Generic.IReadOnlyList<Episode?>? DeserializeEpisodeArray(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            var episodes = new global::System.Collections.Generic.List<Episode?>();

            foreach (global::System.Text.Json.JsonElement child in obj.Value.EnumerateArray())
            {
                episodes.Add(DeserializeEpisode(child));
            }

            return episodes;
        }

        private Episode? DeserializeEpisode(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            return _episodeParser.Parse(obj.Value.GetString()!);
        }
    }
}


// createReviewBuilder

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class createReviewBuilder
        : global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, ICreateReview>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::System.Func<global::System.Text.Json.JsonElement, global::StrawberryShake.EntityId> _extractId;
        private readonly global::StrawberryShake.IOperationResultDataFactory<ICreateReview> _resultDataFactory;
        private global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, Episode> _episodeParser;
        private global::StrawberryShake.Serialization.ILeafValueParser<global::System.Int32, global::System.Int32> _int32Parser;
        private global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::System.String> _stringParser;

        public createReviewBuilder(
            global::StrawberryShake.IEntityStore entityStore,
            global::System.Func<global::System.Text.Json.JsonElement, global::StrawberryShake.EntityId> extractId,
            global::StrawberryShake.IOperationResultDataFactory<ICreateReview> resultDataFactory,
            global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _extractId = extractId
                 ?? throw new global::System.ArgumentNullException(nameof(extractId));
            _resultDataFactory = resultDataFactory
                 ?? throw new global::System.ArgumentNullException(nameof(resultDataFactory));
            _episodeParser = serializerResolver.GetLeafValueParser<global::System.String, Episode>("Episode")
                 ?? throw new global::System.ArgumentNullException(nameof(_episodeParser));
            _int32Parser = serializerResolver.GetLeafValueParser<global::System.Int32, global::System.Int32>("Int")
                 ?? throw new global::System.ArgumentNullException(nameof(_int32Parser));
            _stringParser = serializerResolver.GetLeafValueParser<global::System.String, global::System.String>("String")
                 ?? throw new global::System.ArgumentNullException(nameof(_stringParser));
        }

        public global::StrawberryShake.IOperationResult<ICreateReview> Build(global::StrawberryShake.Response<global::System.Text.Json.JsonDocument> response)
        {
            (ICreateReview Result, CreateReviewInfo Info)? data = null;

            if (response.Body is not null
                && response.Body.RootElement.TryGetProperty("data", out global::System.Text.Json.JsonElement obj))
            {
                data = BuildData(obj);
            }

            return new global::StrawberryShake.OperationResult<ICreateReview>(
                data?.Result,
                data?.Info,
                _resultDataFactory,
                null
            );
        }

        private (ICreateReview, CreateReviewInfo) BuildData(global::System.Text.Json.JsonElement obj)
        {
            using global::StrawberryShake.IEntityUpdateSession session = _entityStore.BeginUpdate();
            var entityIds = new global::System.Collections.Generic.HashSet<global::StrawberryShake.EntityId>();


            var resultInfo = new CreateReviewInfo(
                DeserializeNonNullableICreateReview_CreateReviewData(
                    global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(obj.Value, "createReview"),
                    entityIds
                ),
                entityIds,
                session.Version
            );

            return (_resultDataFactory.Create(resultInfo), resultInfo);
        }

        private ICreateReview_CreateReview DeserializeNonNullableICreateReview_CreateReviewData(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return new ICreateReview_CreateReviewData(
                DeserializeNonNullableInt(global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(obj.Value, "stars")),
                DeserializeString(global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(obj.Value, "commentary"))
            );
        }

        private global::System.Int DeserializeNonNullableInt(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _intParser.Parse(obj.Value.GetInt()!);
        }

        private global::System.String? DeserializeString(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            return _stringParser.Parse(obj.Value.GetString()!);
        }
    }
}


// FooClient

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class FooClient
    {
        private readonly GetHeroQuery _getHeroQuery;
        private readonly createReviewMutation _createReviewMutation;

        public FooClient(
            GetHeroQuery getHeroQuery,
            createReviewMutation createReviewMutation)
        {
            _getHeroQuery = getHeroQuery
                 ?? throw new global::System.ArgumentNullException(nameof(getHeroQuery));
            _createReviewMutation = createReviewMutation
                 ?? throw new global::System.ArgumentNullException(nameof(createReviewMutation));
        }

        public GetHeroQuery GetHeroQuery => _getHeroQuery;

        public createReviewMutation createReviewMutation => _createReviewMutation;
    }
}


// EntityIdFactory

[global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
public static partial class EntityIdFactory
{
    public static global::StrawberryShake.EntityId CreateEntityId(global::System.Text.Json.JsonElement obj)
    {
        global::System.String typeName = obj.GetProperty("__typename").GetString()!;
        
        return typeName switch
        {
            "Droid" => CreateDroidEntityId(obj, typeName),
            "Human" => CreateHumanEntityId(obj, typeName),
            _ => throw new global::System.NotSupportedException()
        };
    }

    private static global::StrawberryShake.EntityId CreateDroidEntityId(
        global::System.Text.Json.JsonElement obj,
        global::System.String type)
    {
        return new global::StrawberryShake.EntityId(
            type,
            obj.GetProperty("id").GetString()!);
    }

    private static global::StrawberryShake.EntityId CreateHumanEntityId(
        global::System.Text.Json.JsonElement obj,
        global::System.String type)
    {
        return new global::StrawberryShake.EntityId(
            type,
            obj.GetProperty("id").GetString()!);
    }
}


