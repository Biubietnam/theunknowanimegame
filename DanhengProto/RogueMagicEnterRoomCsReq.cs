using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EC9 RID: 3785
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicEnterRoomCsReq : IMessage<RogueMagicEnterRoomCsReq>, IMessage, IEquatable<RogueMagicEnterRoomCsReq>, IDeepCloneable<RogueMagicEnterRoomCsReq>, IBufferMessage
	{
		// Token: 0x17002FC4 RID: 12228
		// (get) Token: 0x0600A924 RID: 43300 RVA: 0x001C77F9 File Offset: 0x001C59F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicEnterRoomCsReq> Parser
		{
			get
			{
				return RogueMagicEnterRoomCsReq._parser;
			}
		}

		// Token: 0x17002FC5 RID: 12229
		// (get) Token: 0x0600A925 RID: 43301 RVA: 0x001C7800 File Offset: 0x001C5A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicEnterRoomCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002FC6 RID: 12230
		// (get) Token: 0x0600A926 RID: 43302 RVA: 0x001C7812 File Offset: 0x001C5A12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicEnterRoomCsReq.Descriptor;
			}
		}

		// Token: 0x0600A927 RID: 43303 RVA: 0x001C7819 File Offset: 0x001C5A19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicEnterRoomCsReq()
		{
		}

		// Token: 0x0600A928 RID: 43304 RVA: 0x001C7821 File Offset: 0x001C5A21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicEnterRoomCsReq(RogueMagicEnterRoomCsReq other) : this()
		{
			this.curRoomIndex_ = other.curRoomIndex_;
			this.nextRoomType_ = other.nextRoomType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A929 RID: 43305 RVA: 0x001C7852 File Offset: 0x001C5A52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicEnterRoomCsReq Clone()
		{
			return new RogueMagicEnterRoomCsReq(this);
		}

		// Token: 0x17002FC7 RID: 12231
		// (get) Token: 0x0600A92A RID: 43306 RVA: 0x001C785A File Offset: 0x001C5A5A
		// (set) Token: 0x0600A92B RID: 43307 RVA: 0x001C7862 File Offset: 0x001C5A62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurRoomIndex
		{
			get
			{
				return this.curRoomIndex_;
			}
			set
			{
				this.curRoomIndex_ = value;
			}
		}

		// Token: 0x17002FC8 RID: 12232
		// (get) Token: 0x0600A92C RID: 43308 RVA: 0x001C786B File Offset: 0x001C5A6B
		// (set) Token: 0x0600A92D RID: 43309 RVA: 0x001C7873 File Offset: 0x001C5A73
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

		// Token: 0x0600A92E RID: 43310 RVA: 0x001C787C File Offset: 0x001C5A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicEnterRoomCsReq);
		}

		// Token: 0x0600A92F RID: 43311 RVA: 0x001C788A File Offset: 0x001C5A8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicEnterRoomCsReq other)
		{
			return other != null && (other == this || (this.CurRoomIndex == other.CurRoomIndex && this.NextRoomType == other.NextRoomType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A930 RID: 43312 RVA: 0x001C78C8 File Offset: 0x001C5AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurRoomIndex != 0U)
			{
				num ^= this.CurRoomIndex.GetHashCode();
			}
			if (this.NextRoomType != 0U)
			{
				num ^= this.NextRoomType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A931 RID: 43313 RVA: 0x001C7920 File Offset: 0x001C5B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A932 RID: 43314 RVA: 0x001C7928 File Offset: 0x001C5B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A933 RID: 43315 RVA: 0x001C7934 File Offset: 0x001C5B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NextRoomType != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.NextRoomType);
			}
			if (this.CurRoomIndex != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.CurRoomIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A934 RID: 43316 RVA: 0x001C7990 File Offset: 0x001C5B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurRoomIndex != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurRoomIndex);
			}
			if (this.NextRoomType != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NextRoomType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A935 RID: 43317 RVA: 0x001C79E8 File Offset: 0x001C5BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicEnterRoomCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurRoomIndex != 0U)
			{
				this.CurRoomIndex = other.CurRoomIndex;
			}
			if (other.NextRoomType != 0U)
			{
				this.NextRoomType = other.NextRoomType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A936 RID: 43318 RVA: 0x001C7A38 File Offset: 0x001C5C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A937 RID: 43319 RVA: 0x001C7A44 File Offset: 0x001C5C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CurRoomIndex = input.ReadUInt32();
					}
				}
				else
				{
					this.NextRoomType = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400450F RID: 17679
		private static readonly MessageParser<RogueMagicEnterRoomCsReq> _parser = new MessageParser<RogueMagicEnterRoomCsReq>(() => new RogueMagicEnterRoomCsReq());

		// Token: 0x04004510 RID: 17680
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004511 RID: 17681
		public const int CurRoomIndexFieldNumber = 5;

		// Token: 0x04004512 RID: 17682
		private uint curRoomIndex_;

		// Token: 0x04004513 RID: 17683
		public const int NextRoomTypeFieldNumber = 3;

		// Token: 0x04004514 RID: 17684
		private uint nextRoomType_;
	}
}
