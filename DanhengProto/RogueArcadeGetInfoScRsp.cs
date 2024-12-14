using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DF9 RID: 3577
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueArcadeGetInfoScRsp : IMessage<RogueArcadeGetInfoScRsp>, IMessage, IEquatable<RogueArcadeGetInfoScRsp>, IDeepCloneable<RogueArcadeGetInfoScRsp>, IBufferMessage
	{
		// Token: 0x17002D2E RID: 11566
		// (get) Token: 0x06009FF6 RID: 40950 RVA: 0x001AD744 File Offset: 0x001AB944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueArcadeGetInfoScRsp> Parser
		{
			get
			{
				return RogueArcadeGetInfoScRsp._parser;
			}
		}

		// Token: 0x17002D2F RID: 11567
		// (get) Token: 0x06009FF7 RID: 40951 RVA: 0x001AD74B File Offset: 0x001AB94B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueArcadeGetInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002D30 RID: 11568
		// (get) Token: 0x06009FF8 RID: 40952 RVA: 0x001AD75D File Offset: 0x001AB95D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueArcadeGetInfoScRsp.Descriptor;
			}
		}

		// Token: 0x06009FF9 RID: 40953 RVA: 0x001AD764 File Offset: 0x001AB964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArcadeGetInfoScRsp()
		{
		}

		// Token: 0x06009FFA RID: 40954 RVA: 0x001AD76C File Offset: 0x001AB96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArcadeGetInfoScRsp(RogueArcadeGetInfoScRsp other) : this()
		{
			this.roomId_ = other.roomId_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009FFB RID: 40955 RVA: 0x001AD79D File Offset: 0x001AB99D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArcadeGetInfoScRsp Clone()
		{
			return new RogueArcadeGetInfoScRsp(this);
		}

		// Token: 0x17002D31 RID: 11569
		// (get) Token: 0x06009FFC RID: 40956 RVA: 0x001AD7A5 File Offset: 0x001AB9A5
		// (set) Token: 0x06009FFD RID: 40957 RVA: 0x001AD7AD File Offset: 0x001AB9AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RoomId
		{
			get
			{
				return this.roomId_;
			}
			set
			{
				this.roomId_ = value;
			}
		}

		// Token: 0x17002D32 RID: 11570
		// (get) Token: 0x06009FFE RID: 40958 RVA: 0x001AD7B6 File Offset: 0x001AB9B6
		// (set) Token: 0x06009FFF RID: 40959 RVA: 0x001AD7BE File Offset: 0x001AB9BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x0600A000 RID: 40960 RVA: 0x001AD7C7 File Offset: 0x001AB9C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueArcadeGetInfoScRsp);
		}

		// Token: 0x0600A001 RID: 40961 RVA: 0x001AD7D5 File Offset: 0x001AB9D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueArcadeGetInfoScRsp other)
		{
			return other != null && (other == this || (this.RoomId == other.RoomId && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A002 RID: 40962 RVA: 0x001AD814 File Offset: 0x001ABA14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoomId != 0U)
			{
				num ^= this.RoomId.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A003 RID: 40963 RVA: 0x001AD86C File Offset: 0x001ABA6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A004 RID: 40964 RVA: 0x001AD874 File Offset: 0x001ABA74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A005 RID: 40965 RVA: 0x001AD880 File Offset: 0x001ABA80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			if (this.RoomId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.RoomId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A006 RID: 40966 RVA: 0x001AD8D8 File Offset: 0x001ABAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoomId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RoomId);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A007 RID: 40967 RVA: 0x001AD930 File Offset: 0x001ABB30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueArcadeGetInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoomId != 0U)
			{
				this.RoomId = other.RoomId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A008 RID: 40968 RVA: 0x001AD980 File Offset: 0x001ABB80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A009 RID: 40969 RVA: 0x001AD98C File Offset: 0x001ABB8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RoomId = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004197 RID: 16791
		private static readonly MessageParser<RogueArcadeGetInfoScRsp> _parser = new MessageParser<RogueArcadeGetInfoScRsp>(() => new RogueArcadeGetInfoScRsp());

		// Token: 0x04004198 RID: 16792
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004199 RID: 16793
		public const int RoomIdFieldNumber = 12;

		// Token: 0x0400419A RID: 16794
		private uint roomId_;

		// Token: 0x0400419B RID: 16795
		public const int RetcodeFieldNumber = 1;

		// Token: 0x0400419C RID: 16796
		private uint retcode_;
	}
}
