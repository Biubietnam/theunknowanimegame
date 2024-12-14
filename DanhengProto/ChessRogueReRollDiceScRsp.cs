using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000289 RID: 649
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueReRollDiceScRsp : IMessage<ChessRogueReRollDiceScRsp>, IMessage, IEquatable<ChessRogueReRollDiceScRsp>, IDeepCloneable<ChessRogueReRollDiceScRsp>, IBufferMessage
	{
		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06001CEA RID: 7402 RVA: 0x0005315B File Offset: 0x0005135B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueReRollDiceScRsp> Parser
		{
			get
			{
				return ChessRogueReRollDiceScRsp._parser;
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06001CEB RID: 7403 RVA: 0x00053162 File Offset: 0x00051362
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueReRollDiceScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06001CEC RID: 7404 RVA: 0x00053174 File Offset: 0x00051374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueReRollDiceScRsp.Descriptor;
			}
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x0005317B File Offset: 0x0005137B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueReRollDiceScRsp()
		{
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x00053184 File Offset: 0x00051384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueReRollDiceScRsp(ChessRogueReRollDiceScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.rogueDiceInfo_ = ((other.rogueDiceInfo_ != null) ? other.rogueDiceInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x000531D0 File Offset: 0x000513D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueReRollDiceScRsp Clone()
		{
			return new ChessRogueReRollDiceScRsp(this);
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06001CF0 RID: 7408 RVA: 0x000531D8 File Offset: 0x000513D8
		// (set) Token: 0x06001CF1 RID: 7409 RVA: 0x000531E0 File Offset: 0x000513E0
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

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06001CF2 RID: 7410 RVA: 0x000531E9 File Offset: 0x000513E9
		// (set) Token: 0x06001CF3 RID: 7411 RVA: 0x000531F1 File Offset: 0x000513F1
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

		// Token: 0x06001CF4 RID: 7412 RVA: 0x000531FA File Offset: 0x000513FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueReRollDiceScRsp);
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x00053208 File Offset: 0x00051408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueReRollDiceScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.RogueDiceInfo, other.RogueDiceInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x00053258 File Offset: 0x00051458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x06001CF7 RID: 7415 RVA: 0x000532AD File Offset: 0x000514AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x000532B5 File Offset: 0x000514B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001CF9 RID: 7417 RVA: 0x000532C0 File Offset: 0x000514C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			if (this.rogueDiceInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.RogueDiceInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001CFA RID: 7418 RVA: 0x0005331C File Offset: 0x0005151C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x06001CFB RID: 7419 RVA: 0x00053374 File Offset: 0x00051574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueReRollDiceScRsp other)
		{
			if (other == null)
			{
				return;
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

		// Token: 0x06001CFC RID: 7420 RVA: 0x000533DC File Offset: 0x000515DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001CFD RID: 7421 RVA: 0x000533E8 File Offset: 0x000515E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 90U)
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
		}

		// Token: 0x04000C1D RID: 3101
		private static readonly MessageParser<ChessRogueReRollDiceScRsp> _parser = new MessageParser<ChessRogueReRollDiceScRsp>(() => new ChessRogueReRollDiceScRsp());

		// Token: 0x04000C1E RID: 3102
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000C1F RID: 3103
		public const int RetcodeFieldNumber = 3;

		// Token: 0x04000C20 RID: 3104
		private uint retcode_;

		// Token: 0x04000C21 RID: 3105
		public const int RogueDiceInfoFieldNumber = 11;

		// Token: 0x04000C22 RID: 3106
		private ChessRogueDiceInfo rogueDiceInfo_;
	}
}
