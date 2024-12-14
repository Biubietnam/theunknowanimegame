using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001061 RID: 4193
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SceneEntityGroupInfo : IMessage<SceneEntityGroupInfo>, IMessage, IEquatable<SceneEntityGroupInfo>, IDeepCloneable<SceneEntityGroupInfo>, IBufferMessage
	{
		// Token: 0x170034A1 RID: 13473
		// (get) Token: 0x0600BAA2 RID: 47778 RVA: 0x001F5AC3 File Offset: 0x001F3CC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneEntityGroupInfo> Parser
		{
			get
			{
				return SceneEntityGroupInfo._parser;
			}
		}

		// Token: 0x170034A2 RID: 13474
		// (get) Token: 0x0600BAA3 RID: 47779 RVA: 0x001F5ACA File Offset: 0x001F3CCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SceneEntityGroupInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170034A3 RID: 13475
		// (get) Token: 0x0600BAA4 RID: 47780 RVA: 0x001F5ADC File Offset: 0x001F3CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneEntityGroupInfo.Descriptor;
			}
		}

		// Token: 0x0600BAA5 RID: 47781 RVA: 0x001F5AE3 File Offset: 0x001F3CE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneEntityGroupInfo()
		{
		}

		// Token: 0x0600BAA6 RID: 47782 RVA: 0x001F5AF8 File Offset: 0x001F3CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneEntityGroupInfo(SceneEntityGroupInfo other) : this()
		{
			this.state_ = other.state_;
			this.entityList_ = other.entityList_.Clone();
			this.groupId_ = other.groupId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BAA7 RID: 47783 RVA: 0x001F5B45 File Offset: 0x001F3D45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneEntityGroupInfo Clone()
		{
			return new SceneEntityGroupInfo(this);
		}

		// Token: 0x170034A4 RID: 13476
		// (get) Token: 0x0600BAA8 RID: 47784 RVA: 0x001F5B4D File Offset: 0x001F3D4D
		// (set) Token: 0x0600BAA9 RID: 47785 RVA: 0x001F5B55 File Offset: 0x001F3D55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x170034A5 RID: 13477
		// (get) Token: 0x0600BAAA RID: 47786 RVA: 0x001F5B5E File Offset: 0x001F3D5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SceneEntityInfo> EntityList
		{
			get
			{
				return this.entityList_;
			}
		}

		// Token: 0x170034A6 RID: 13478
		// (get) Token: 0x0600BAAB RID: 47787 RVA: 0x001F5B66 File Offset: 0x001F3D66
		// (set) Token: 0x0600BAAC RID: 47788 RVA: 0x001F5B6E File Offset: 0x001F3D6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x0600BAAD RID: 47789 RVA: 0x001F5B77 File Offset: 0x001F3D77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneEntityGroupInfo);
		}

		// Token: 0x0600BAAE RID: 47790 RVA: 0x001F5B88 File Offset: 0x001F3D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneEntityGroupInfo other)
		{
			return other != null && (other == this || (this.State == other.State && this.entityList_.Equals(other.entityList_) && this.GroupId == other.GroupId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BAAF RID: 47791 RVA: 0x001F5BE8 File Offset: 0x001F3DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.State != 0U)
			{
				num ^= this.State.GetHashCode();
			}
			num ^= this.entityList_.GetHashCode();
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BAB0 RID: 47792 RVA: 0x001F5C4E File Offset: 0x001F3E4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BAB1 RID: 47793 RVA: 0x001F5C56 File Offset: 0x001F3E56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BAB2 RID: 47794 RVA: 0x001F5C60 File Offset: 0x001F3E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entityList_.WriteTo(ref output, SceneEntityGroupInfo._repeated_entityList_codec);
			if (this.State != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.State);
			}
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BAB3 RID: 47795 RVA: 0x001F5CCC File Offset: 0x001F3ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.State != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.State);
			}
			num += this.entityList_.CalculateSize(SceneEntityGroupInfo._repeated_entityList_codec);
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BAB4 RID: 47796 RVA: 0x001F5D38 File Offset: 0x001F3F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneEntityGroupInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.State != 0U)
			{
				this.State = other.State;
			}
			this.entityList_.Add(other.entityList_);
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BAB5 RID: 47797 RVA: 0x001F5D99 File Offset: 0x001F3F99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BAB6 RID: 47798 RVA: 0x001F5DA4 File Offset: 0x001F3FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 80U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.GroupId = input.ReadUInt32();
						}
					}
					else
					{
						this.State = input.ReadUInt32();
					}
				}
				else
				{
					this.entityList_.AddEntriesFrom(ref input, SceneEntityGroupInfo._repeated_entityList_codec);
				}
			}
		}

		// Token: 0x04004BB2 RID: 19378
		private static readonly MessageParser<SceneEntityGroupInfo> _parser = new MessageParser<SceneEntityGroupInfo>(() => new SceneEntityGroupInfo());

		// Token: 0x04004BB3 RID: 19379
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BB4 RID: 19380
		public const int StateFieldNumber = 10;

		// Token: 0x04004BB5 RID: 19381
		private uint state_;

		// Token: 0x04004BB6 RID: 19382
		public const int EntityListFieldNumber = 2;

		// Token: 0x04004BB7 RID: 19383
		private static readonly FieldCodec<SceneEntityInfo> _repeated_entityList_codec = FieldCodec.ForMessage<SceneEntityInfo>(18U, SceneEntityInfo.Parser);

		// Token: 0x04004BB8 RID: 19384
		private readonly RepeatedField<SceneEntityInfo> entityList_ = new RepeatedField<SceneEntityInfo>();

		// Token: 0x04004BB9 RID: 19385
		public const int GroupIdFieldNumber = 15;

		// Token: 0x04004BBA RID: 19386
		private uint groupId_;
	}
}
