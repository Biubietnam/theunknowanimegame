using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000043 RID: 67
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AddBlacklistScRsp : IMessage<AddBlacklistScRsp>, IMessage, IEquatable<AddBlacklistScRsp>, IDeepCloneable<AddBlacklistScRsp>, IBufferMessage
	{
		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000298 RID: 664 RVA: 0x00008511 File Offset: 0x00006711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AddBlacklistScRsp> Parser
		{
			get
			{
				return AddBlacklistScRsp._parser;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000299 RID: 665 RVA: 0x00008518 File Offset: 0x00006718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AddBlacklistScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600029A RID: 666 RVA: 0x0000852A File Offset: 0x0000672A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddBlacklistScRsp.Descriptor;
			}
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00008531 File Offset: 0x00006731
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddBlacklistScRsp()
		{
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000853C File Offset: 0x0000673C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddBlacklistScRsp(AddBlacklistScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.blackInfo_ = ((other.blackInfo_ != null) ? other.blackInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00008588 File Offset: 0x00006788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddBlacklistScRsp Clone()
		{
			return new AddBlacklistScRsp(this);
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600029E RID: 670 RVA: 0x00008590 File Offset: 0x00006790
		// (set) Token: 0x0600029F RID: 671 RVA: 0x00008598 File Offset: 0x00006798
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

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x000085A1 File Offset: 0x000067A1
		// (set) Token: 0x060002A1 RID: 673 RVA: 0x000085A9 File Offset: 0x000067A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSimpleInfo BlackInfo
		{
			get
			{
				return this.blackInfo_;
			}
			set
			{
				this.blackInfo_ = value;
			}
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x000085B2 File Offset: 0x000067B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddBlacklistScRsp);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x000085C0 File Offset: 0x000067C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddBlacklistScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.BlackInfo, other.BlackInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00008610 File Offset: 0x00006810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.blackInfo_ != null)
			{
				num ^= this.BlackInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00008665 File Offset: 0x00006865
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000866D File Offset: 0x0000686D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00008678 File Offset: 0x00006878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this.blackInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.BlackInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x000086D4 File Offset: 0x000068D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.blackInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BlackInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0000872C File Offset: 0x0000692C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddBlacklistScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.blackInfo_ != null)
			{
				if (this.blackInfo_ == null)
				{
					this.BlackInfo = new PlayerSimpleInfo();
				}
				this.BlackInfo.MergeFrom(other.BlackInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00008794 File Offset: 0x00006994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x000087A0 File Offset: 0x000069A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.blackInfo_ == null)
						{
							this.BlackInfo = new PlayerSimpleInfo();
						}
						input.ReadMessage(this.BlackInfo);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040000F0 RID: 240
		private static readonly MessageParser<AddBlacklistScRsp> _parser = new MessageParser<AddBlacklistScRsp>(() => new AddBlacklistScRsp());

		// Token: 0x040000F1 RID: 241
		private UnknownFieldSet _unknownFields;

		// Token: 0x040000F2 RID: 242
		public const int RetcodeFieldNumber = 8;

		// Token: 0x040000F3 RID: 243
		private uint retcode_;

		// Token: 0x040000F4 RID: 244
		public const int BlackInfoFieldNumber = 13;

		// Token: 0x040000F5 RID: 245
		private PlayerSimpleInfo blackInfo_;
	}
}
