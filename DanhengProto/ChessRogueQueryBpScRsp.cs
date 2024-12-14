using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000273 RID: 627
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueQueryBpScRsp : IMessage<ChessRogueQueryBpScRsp>, IMessage, IEquatable<ChessRogueQueryBpScRsp>, IDeepCloneable<ChessRogueQueryBpScRsp>, IBufferMessage
	{
		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x06001BF0 RID: 7152 RVA: 0x00050171 File Offset: 0x0004E371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueQueryBpScRsp> Parser
		{
			get
			{
				return ChessRogueQueryBpScRsp._parser;
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x06001BF1 RID: 7153 RVA: 0x00050178 File Offset: 0x0004E378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueQueryBpScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x06001BF2 RID: 7154 RVA: 0x0005018A File Offset: 0x0004E38A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueQueryBpScRsp.Descriptor;
			}
		}

		// Token: 0x06001BF3 RID: 7155 RVA: 0x00050191 File Offset: 0x0004E391
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryBpScRsp()
		{
		}

		// Token: 0x06001BF4 RID: 7156 RVA: 0x0005019C File Offset: 0x0004E39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryBpScRsp(ChessRogueQueryBpScRsp other) : this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x000501E8 File Offset: 0x0004E3E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryBpScRsp Clone()
		{
			return new ChessRogueQueryBpScRsp(this);
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x06001BF6 RID: 7158 RVA: 0x000501F0 File Offset: 0x0004E3F0
		// (set) Token: 0x06001BF7 RID: 7159 RVA: 0x000501F8 File Offset: 0x0004E3F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FPEHFCFNNME Info
		{
			get
			{
				return this.info_;
			}
			set
			{
				this.info_ = value;
			}
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x06001BF8 RID: 7160 RVA: 0x00050201 File Offset: 0x0004E401
		// (set) Token: 0x06001BF9 RID: 7161 RVA: 0x00050209 File Offset: 0x0004E409
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

		// Token: 0x06001BFA RID: 7162 RVA: 0x00050212 File Offset: 0x0004E412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueQueryBpScRsp);
		}

		// Token: 0x06001BFB RID: 7163 RVA: 0x00050220 File Offset: 0x0004E420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueQueryBpScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.Info, other.Info) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x00050270 File Offset: 0x0004E470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.info_ != null)
			{
				num ^= this.Info.GetHashCode();
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

		// Token: 0x06001BFD RID: 7165 RVA: 0x000502C5 File Offset: 0x0004E4C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x000502CD File Offset: 0x0004E4CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x000502D8 File Offset: 0x0004E4D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			if (this.info_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Info);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x00050330 File Offset: 0x0004E530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
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

		// Token: 0x06001C01 RID: 7169 RVA: 0x00050388 File Offset: 0x0004E588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueQueryBpScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.info_ != null)
			{
				if (this.info_ == null)
				{
					this.Info = new FPEHFCFNNME();
				}
				this.Info.MergeFrom(other.Info);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001C02 RID: 7170 RVA: 0x000503F0 File Offset: 0x0004E5F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x000503FC File Offset: 0x0004E5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 26U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.info_ == null)
						{
							this.Info = new FPEHFCFNNME();
						}
						input.ReadMessage(this.Info);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000BB1 RID: 2993
		private static readonly MessageParser<ChessRogueQueryBpScRsp> _parser = new MessageParser<ChessRogueQueryBpScRsp>(() => new ChessRogueQueryBpScRsp());

		// Token: 0x04000BB2 RID: 2994
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000BB3 RID: 2995
		public const int InfoFieldNumber = 3;

		// Token: 0x04000BB4 RID: 2996
		private FPEHFCFNNME info_;

		// Token: 0x04000BB5 RID: 2997
		public const int RetcodeFieldNumber = 1;

		// Token: 0x04000BB6 RID: 2998
		private uint retcode_;
	}
}
