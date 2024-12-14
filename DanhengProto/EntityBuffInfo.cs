using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000489 RID: 1161
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EntityBuffInfo : IMessage<EntityBuffInfo>, IMessage, IEquatable<EntityBuffInfo>, IDeepCloneable<EntityBuffInfo>, IBufferMessage
	{
		// Token: 0x17000EBF RID: 3775
		// (get) Token: 0x060033B8 RID: 13240 RVA: 0x0008E121 File Offset: 0x0008C321
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EntityBuffInfo> Parser
		{
			get
			{
				return EntityBuffInfo._parser;
			}
		}

		// Token: 0x17000EC0 RID: 3776
		// (get) Token: 0x060033B9 RID: 13241 RVA: 0x0008E128 File Offset: 0x0008C328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EntityBuffInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000EC1 RID: 3777
		// (get) Token: 0x060033BA RID: 13242 RVA: 0x0008E13A File Offset: 0x0008C33A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityBuffInfo.Descriptor;
			}
		}

		// Token: 0x060033BB RID: 13243 RVA: 0x0008E141 File Offset: 0x0008C341
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBuffInfo()
		{
		}

		// Token: 0x060033BC RID: 13244 RVA: 0x0008E154 File Offset: 0x0008C354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBuffInfo(EntityBuffInfo other) : this()
		{
			this.entityId_ = other.entityId_;
			this.buffList_ = other.buffList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060033BD RID: 13245 RVA: 0x0008E18A File Offset: 0x0008C38A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBuffInfo Clone()
		{
			return new EntityBuffInfo(this);
		}

		// Token: 0x17000EC2 RID: 3778
		// (get) Token: 0x060033BE RID: 13246 RVA: 0x0008E192 File Offset: 0x0008C392
		// (set) Token: 0x060033BF RID: 13247 RVA: 0x0008E19A File Offset: 0x0008C39A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17000EC3 RID: 3779
		// (get) Token: 0x060033C0 RID: 13248 RVA: 0x0008E1A3 File Offset: 0x0008C3A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BuffInfo> BuffList
		{
			get
			{
				return this.buffList_;
			}
		}

		// Token: 0x060033C1 RID: 13249 RVA: 0x0008E1AB File Offset: 0x0008C3AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityBuffInfo);
		}

		// Token: 0x060033C2 RID: 13250 RVA: 0x0008E1BC File Offset: 0x0008C3BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityBuffInfo other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.buffList_.Equals(other.buffList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060033C3 RID: 13251 RVA: 0x0008E20C File Offset: 0x0008C40C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0U)
			{
				num ^= this.EntityId.GetHashCode();
			}
			num ^= this.buffList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060033C4 RID: 13252 RVA: 0x0008E259 File Offset: 0x0008C459
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060033C5 RID: 13253 RVA: 0x0008E261 File Offset: 0x0008C461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060033C6 RID: 13254 RVA: 0x0008E26C File Offset: 0x0008C46C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.EntityId);
			}
			this.buffList_.WriteTo(ref output, EntityBuffInfo._repeated_buffList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060033C7 RID: 13255 RVA: 0x0008E2BC File Offset: 0x0008C4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EntityId);
			}
			num += this.buffList_.CalculateSize(EntityBuffInfo._repeated_buffList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060033C8 RID: 13256 RVA: 0x0008E310 File Offset: 0x0008C510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityBuffInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0U)
			{
				this.EntityId = other.EntityId;
			}
			this.buffList_.Add(other.buffList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060033C9 RID: 13257 RVA: 0x0008E35D File Offset: 0x0008C55D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060033CA RID: 13258 RVA: 0x0008E368 File Offset: 0x0008C568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.buffList_.AddEntriesFrom(ref input, EntityBuffInfo._repeated_buffList_codec);
					}
				}
				else
				{
					this.EntityId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001488 RID: 5256
		private static readonly MessageParser<EntityBuffInfo> _parser = new MessageParser<EntityBuffInfo>(() => new EntityBuffInfo());

		// Token: 0x04001489 RID: 5257
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400148A RID: 5258
		public const int EntityIdFieldNumber = 1;

		// Token: 0x0400148B RID: 5259
		private uint entityId_;

		// Token: 0x0400148C RID: 5260
		public const int BuffListFieldNumber = 10;

		// Token: 0x0400148D RID: 5261
		private static readonly FieldCodec<BuffInfo> _repeated_buffList_codec = FieldCodec.ForMessage<BuffInfo>(82U, BuffInfo.Parser);

		// Token: 0x0400148E RID: 5262
		private readonly RepeatedField<BuffInfo> buffList_ = new RepeatedField<BuffInfo>();
	}
}
