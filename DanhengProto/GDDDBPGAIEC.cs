using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005EB RID: 1515
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GDDDBPGAIEC : IMessage<GDDDBPGAIEC>, IMessage, IEquatable<GDDDBPGAIEC>, IDeepCloneable<GDDDBPGAIEC>, IBufferMessage
	{
		// Token: 0x1700136D RID: 4973
		// (get) Token: 0x06004407 RID: 17415 RVA: 0x000BAE99 File Offset: 0x000B9099
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GDDDBPGAIEC> Parser
		{
			get
			{
				return GDDDBPGAIEC._parser;
			}
		}

		// Token: 0x1700136E RID: 4974
		// (get) Token: 0x06004408 RID: 17416 RVA: 0x000BAEA0 File Offset: 0x000B90A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GDDDBPGAIECReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700136F RID: 4975
		// (get) Token: 0x06004409 RID: 17417 RVA: 0x000BAEB2 File Offset: 0x000B90B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GDDDBPGAIEC.Descriptor;
			}
		}

		// Token: 0x0600440A RID: 17418 RVA: 0x000BAEB9 File Offset: 0x000B90B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GDDDBPGAIEC()
		{
		}

		// Token: 0x0600440B RID: 17419 RVA: 0x000BAEC1 File Offset: 0x000B90C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GDDDBPGAIEC(GDDDBPGAIEC other) : this()
		{
			this.avatarType_ = other.avatarType_;
			this.assistUid_ = other.assistUid_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600440C RID: 17420 RVA: 0x000BAEFE File Offset: 0x000B90FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GDDDBPGAIEC Clone()
		{
			return new GDDDBPGAIEC(this);
		}

		// Token: 0x17001370 RID: 4976
		// (get) Token: 0x0600440D RID: 17421 RVA: 0x000BAF06 File Offset: 0x000B9106
		// (set) Token: 0x0600440E RID: 17422 RVA: 0x000BAF0E File Offset: 0x000B910E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarType AvatarType
		{
			get
			{
				return this.avatarType_;
			}
			set
			{
				this.avatarType_ = value;
			}
		}

		// Token: 0x17001371 RID: 4977
		// (get) Token: 0x0600440F RID: 17423 RVA: 0x000BAF17 File Offset: 0x000B9117
		// (set) Token: 0x06004410 RID: 17424 RVA: 0x000BAF1F File Offset: 0x000B911F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AssistUid
		{
			get
			{
				return this.assistUid_;
			}
			set
			{
				this.assistUid_ = value;
			}
		}

		// Token: 0x17001372 RID: 4978
		// (get) Token: 0x06004411 RID: 17425 RVA: 0x000BAF28 File Offset: 0x000B9128
		// (set) Token: 0x06004412 RID: 17426 RVA: 0x000BAF30 File Offset: 0x000B9130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x06004413 RID: 17427 RVA: 0x000BAF39 File Offset: 0x000B9139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GDDDBPGAIEC);
		}

		// Token: 0x06004414 RID: 17428 RVA: 0x000BAF48 File Offset: 0x000B9148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GDDDBPGAIEC other)
		{
			return other != null && (other == this || (this.AvatarType == other.AvatarType && this.AssistUid == other.AssistUid && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004415 RID: 17429 RVA: 0x000BAFA4 File Offset: 0x000B91A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AvatarType != AvatarType.None)
			{
				num ^= this.AvatarType.GetHashCode();
			}
			if (this.AssistUid != 0U)
			{
				num ^= this.AssistUid.GetHashCode();
			}
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004416 RID: 17430 RVA: 0x000BB01B File Offset: 0x000B921B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004417 RID: 17431 RVA: 0x000BB023 File Offset: 0x000B9223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004418 RID: 17432 RVA: 0x000BB02C File Offset: 0x000B922C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AvatarType != AvatarType.None)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.AvatarType);
			}
			if (this.Id != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Id);
			}
			if (this.AssistUid != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.AssistUid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004419 RID: 17433 RVA: 0x000BB0A4 File Offset: 0x000B92A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AvatarType != AvatarType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.AvatarType);
			}
			if (this.AssistUid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AssistUid);
			}
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600441A RID: 17434 RVA: 0x000BB114 File Offset: 0x000B9314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GDDDBPGAIEC other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AvatarType != AvatarType.None)
			{
				this.AvatarType = other.AvatarType;
			}
			if (other.AssistUid != 0U)
			{
				this.AssistUid = other.AssistUid;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600441B RID: 17435 RVA: 0x000BB178 File Offset: 0x000B9378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600441C RID: 17436 RVA: 0x000BB184 File Offset: 0x000B9384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 88U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.AssistUid = input.ReadUInt32();
						}
					}
					else
					{
						this.Id = input.ReadUInt32();
					}
				}
				else
				{
					this.AvatarType = (AvatarType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04001B43 RID: 6979
		private static readonly MessageParser<GDDDBPGAIEC> _parser = new MessageParser<GDDDBPGAIEC>(() => new GDDDBPGAIEC());

		// Token: 0x04001B44 RID: 6980
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001B45 RID: 6981
		public const int AvatarTypeFieldNumber = 5;

		// Token: 0x04001B46 RID: 6982
		private AvatarType avatarType_;

		// Token: 0x04001B47 RID: 6983
		public const int AssistUidFieldNumber = 15;

		// Token: 0x04001B48 RID: 6984
		private uint assistUid_;

		// Token: 0x04001B49 RID: 6985
		public const int IdFieldNumber = 11;

		// Token: 0x04001B4A RID: 6986
		private uint id_;
	}
}
