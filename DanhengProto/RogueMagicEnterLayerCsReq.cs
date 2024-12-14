using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EC5 RID: 3781
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicEnterLayerCsReq : IMessage<RogueMagicEnterLayerCsReq>, IMessage, IEquatable<RogueMagicEnterLayerCsReq>, IDeepCloneable<RogueMagicEnterLayerCsReq>, IBufferMessage
	{
		// Token: 0x17002FB8 RID: 12216
		// (get) Token: 0x0600A8F6 RID: 43254 RVA: 0x001C7115 File Offset: 0x001C5315
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicEnterLayerCsReq> Parser
		{
			get
			{
				return RogueMagicEnterLayerCsReq._parser;
			}
		}

		// Token: 0x17002FB9 RID: 12217
		// (get) Token: 0x0600A8F7 RID: 43255 RVA: 0x001C711C File Offset: 0x001C531C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicEnterLayerCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002FBA RID: 12218
		// (get) Token: 0x0600A8F8 RID: 43256 RVA: 0x001C712E File Offset: 0x001C532E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicEnterLayerCsReq.Descriptor;
			}
		}

		// Token: 0x0600A8F9 RID: 43257 RVA: 0x001C7135 File Offset: 0x001C5335
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicEnterLayerCsReq()
		{
		}

		// Token: 0x0600A8FA RID: 43258 RVA: 0x001C713D File Offset: 0x001C533D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicEnterLayerCsReq(RogueMagicEnterLayerCsReq other) : this()
		{
			this.nextRoomType_ = other.nextRoomType_;
			this.curLevelIndex_ = other.curLevelIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A8FB RID: 43259 RVA: 0x001C716E File Offset: 0x001C536E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicEnterLayerCsReq Clone()
		{
			return new RogueMagicEnterLayerCsReq(this);
		}

		// Token: 0x17002FBB RID: 12219
		// (get) Token: 0x0600A8FC RID: 43260 RVA: 0x001C7176 File Offset: 0x001C5376
		// (set) Token: 0x0600A8FD RID: 43261 RVA: 0x001C717E File Offset: 0x001C537E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NextRoomType
		{
			get
			{
				return this.nextRoomType_;
			}
			set
			{
				this.nextRoomType_ = value;
			}
		}

		// Token: 0x17002FBC RID: 12220
		// (get) Token: 0x0600A8FE RID: 43262 RVA: 0x001C7187 File Offset: 0x001C5387
		// (set) Token: 0x0600A8FF RID: 43263 RVA: 0x001C718F File Offset: 0x001C538F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurLevelIndex
		{
			get
			{
				return this.curLevelIndex_;
			}
			set
			{
				this.curLevelIndex_ = value;
			}
		}

		// Token: 0x0600A900 RID: 43264 RVA: 0x001C7198 File Offset: 0x001C5398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicEnterLayerCsReq);
		}

		// Token: 0x0600A901 RID: 43265 RVA: 0x001C71A6 File Offset: 0x001C53A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicEnterLayerCsReq other)
		{
			return other != null && (other == this || (this.NextRoomType == other.NextRoomType && this.CurLevelIndex == other.CurLevelIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A902 RID: 43266 RVA: 0x001C71E4 File Offset: 0x001C53E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NextRoomType != 0U)
			{
				num ^= this.NextRoomType.GetHashCode();
			}
			if (this.CurLevelIndex != 0U)
			{
				num ^= this.CurLevelIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A903 RID: 43267 RVA: 0x001C723C File Offset: 0x001C543C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A904 RID: 43268 RVA: 0x001C7244 File Offset: 0x001C5444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A905 RID: 43269 RVA: 0x001C7250 File Offset: 0x001C5450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NextRoomType != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.NextRoomType);
			}
			if (this.CurLevelIndex != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.CurLevelIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A906 RID: 43270 RVA: 0x001C72A8 File Offset: 0x001C54A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NextRoomType != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NextRoomType);
			}
			if (this.CurLevelIndex != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurLevelIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A907 RID: 43271 RVA: 0x001C7300 File Offset: 0x001C5500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicEnterLayerCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NextRoomType != 0U)
			{
				this.NextRoomType = other.NextRoomType;
			}
			if (other.CurLevelIndex != 0U)
			{
				this.CurLevelIndex = other.CurLevelIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A908 RID: 43272 RVA: 0x001C7350 File Offset: 0x001C5550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A909 RID: 43273 RVA: 0x001C735C File Offset: 0x001C555C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CurLevelIndex = input.ReadUInt32();
					}
				}
				else
				{
					this.NextRoomType = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004501 RID: 17665
		private static readonly MessageParser<RogueMagicEnterLayerCsReq> _parser = new MessageParser<RogueMagicEnterLayerCsReq>(() => new RogueMagicEnterLayerCsReq());

		// Token: 0x04004502 RID: 17666
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004503 RID: 17667
		public const int NextRoomTypeFieldNumber = 1;

		// Token: 0x04004504 RID: 17668
		private uint nextRoomType_;

		// Token: 0x04004505 RID: 17669
		public const int CurLevelIndexFieldNumber = 11;

		// Token: 0x04004506 RID: 17670
		private uint curLevelIndex_;
	}
}
