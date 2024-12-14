using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000291 RID: 657
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueRollDiceScRsp : IMessage<ChessRogueRollDiceScRsp>, IMessage, IEquatable<ChessRogueRollDiceScRsp>, IDeepCloneable<ChessRogueRollDiceScRsp>, IBufferMessage
	{
		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06001D44 RID: 7492 RVA: 0x00053F3B File Offset: 0x0005213B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueRollDiceScRsp> Parser
		{
			get
			{
				return ChessRogueRollDiceScRsp._parser;
			}
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06001D45 RID: 7493 RVA: 0x00053F42 File Offset: 0x00052142
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueRollDiceScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06001D46 RID: 7494 RVA: 0x00053F54 File Offset: 0x00052154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueRollDiceScRsp.Descriptor;
			}
		}

		// Token: 0x06001D47 RID: 7495 RVA: 0x00053F5B File Offset: 0x0005215B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueRollDiceScRsp()
		{
		}

		// Token: 0x06001D48 RID: 7496 RVA: 0x00053F64 File Offset: 0x00052164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueRollDiceScRsp(ChessRogueRollDiceScRsp other) : this()
		{
			this.jDHBHNMPIPI_ = other.jDHBHNMPIPI_;
			this.retcode_ = other.retcode_;
			this.rogueDiceInfo_ = ((other.rogueDiceInfo_ != null) ? other.rogueDiceInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001D49 RID: 7497 RVA: 0x00053FBC File Offset: 0x000521BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueRollDiceScRsp Clone()
		{
			return new ChessRogueRollDiceScRsp(this);
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06001D4A RID: 7498 RVA: 0x00053FC4 File Offset: 0x000521C4
		// (set) Token: 0x06001D4B RID: 7499 RVA: 0x00053FCC File Offset: 0x000521CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JDHBHNMPIPI
		{
			get
			{
				return this.jDHBHNMPIPI_;
			}
			set
			{
				this.jDHBHNMPIPI_ = value;
			}
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06001D4C RID: 7500 RVA: 0x00053FD5 File Offset: 0x000521D5
		// (set) Token: 0x06001D4D RID: 7501 RVA: 0x00053FDD File Offset: 0x000521DD
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

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x06001D4E RID: 7502 RVA: 0x00053FE6 File Offset: 0x000521E6
		// (set) Token: 0x06001D4F RID: 7503 RVA: 0x00053FEE File Offset: 0x000521EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueDiceInfo RogueDiceInfo
		{
			get
			{
				return this.rogueDiceInfo_;
			}
			set
			{
				this.rogueDiceInfo_ = value;
			}
		}

		// Token: 0x06001D50 RID: 7504 RVA: 0x00053FF7 File Offset: 0x000521F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueRollDiceScRsp);
		}

		// Token: 0x06001D51 RID: 7505 RVA: 0x00054008 File Offset: 0x00052208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueRollDiceScRsp other)
		{
			return other != null && (other == this || (this.JDHBHNMPIPI == other.JDHBHNMPIPI && this.Retcode == other.Retcode && object.Equals(this.RogueDiceInfo, other.RogueDiceInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001D52 RID: 7506 RVA: 0x00054068 File Offset: 0x00052268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.JDHBHNMPIPI != 0U)
			{
				num ^= this.JDHBHNMPIPI.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.rogueDiceInfo_ != null)
			{
				num ^= this.RogueDiceInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001D53 RID: 7507 RVA: 0x000540D6 File Offset: 0x000522D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001D54 RID: 7508 RVA: 0x000540DE File Offset: 0x000522DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001D55 RID: 7509 RVA: 0x000540E8 File Offset: 0x000522E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.JDHBHNMPIPI != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.JDHBHNMPIPI);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			if (this.rogueDiceInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.RogueDiceInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001D56 RID: 7510 RVA: 0x0005415C File Offset: 0x0005235C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.JDHBHNMPIPI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JDHBHNMPIPI);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.rogueDiceInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueDiceInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001D57 RID: 7511 RVA: 0x000541CC File Offset: 0x000523CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueRollDiceScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.JDHBHNMPIPI != 0U)
			{
				this.JDHBHNMPIPI = other.JDHBHNMPIPI;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.rogueDiceInfo_ != null)
			{
				if (this.rogueDiceInfo_ == null)
				{
					this.RogueDiceInfo = new ChessRogueDiceInfo();
				}
				this.RogueDiceInfo.MergeFrom(other.RogueDiceInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001D58 RID: 7512 RVA: 0x00054248 File Offset: 0x00052448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001D59 RID: 7513 RVA: 0x00054254 File Offset: 0x00052454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 80U)
					{
						if (num != 98U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.rogueDiceInfo_ == null)
							{
								this.RogueDiceInfo = new ChessRogueDiceInfo();
							}
							input.ReadMessage(this.RogueDiceInfo);
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.JDHBHNMPIPI = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000C3B RID: 3131
		private static readonly MessageParser<ChessRogueRollDiceScRsp> _parser = new MessageParser<ChessRogueRollDiceScRsp>(() => new ChessRogueRollDiceScRsp());

		// Token: 0x04000C3C RID: 3132
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000C3D RID: 3133
		public const int JDHBHNMPIPIFieldNumber = 1;

		// Token: 0x04000C3E RID: 3134
		private uint jDHBHNMPIPI_;

		// Token: 0x04000C3F RID: 3135
		public const int RetcodeFieldNumber = 10;

		// Token: 0x04000C40 RID: 3136
		private uint retcode_;

		// Token: 0x04000C41 RID: 3137
		public const int RogueDiceInfoFieldNumber = 12;

		// Token: 0x04000C42 RID: 3138
		private ChessRogueDiceInfo rogueDiceInfo_;
	}
}
