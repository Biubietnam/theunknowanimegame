using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B05 RID: 2821
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyAcceptQuizScRsp : IMessage<MonopolyAcceptQuizScRsp>, IMessage, IEquatable<MonopolyAcceptQuizScRsp>, IDeepCloneable<MonopolyAcceptQuizScRsp>, IBufferMessage
	{
		// Token: 0x1700230E RID: 8974
		// (get) Token: 0x06007CD8 RID: 31960 RVA: 0x0014A921 File Offset: 0x00148B21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyAcceptQuizScRsp> Parser
		{
			get
			{
				return MonopolyAcceptQuizScRsp._parser;
			}
		}

		// Token: 0x1700230F RID: 8975
		// (get) Token: 0x06007CD9 RID: 31961 RVA: 0x0014A928 File Offset: 0x00148B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyAcceptQuizScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002310 RID: 8976
		// (get) Token: 0x06007CDA RID: 31962 RVA: 0x0014A93A File Offset: 0x00148B3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyAcceptQuizScRsp.Descriptor;
			}
		}

		// Token: 0x06007CDB RID: 31963 RVA: 0x0014A941 File Offset: 0x00148B41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyAcceptQuizScRsp()
		{
		}

		// Token: 0x06007CDC RID: 31964 RVA: 0x0014A94C File Offset: 0x00148B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyAcceptQuizScRsp(MonopolyAcceptQuizScRsp other) : this()
		{
			this.kIOAHBIDMPC_ = ((other.kIOAHBIDMPC_ != null) ? other.kIOAHBIDMPC_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007CDD RID: 31965 RVA: 0x0014A998 File Offset: 0x00148B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyAcceptQuizScRsp Clone()
		{
			return new MonopolyAcceptQuizScRsp(this);
		}

		// Token: 0x17002311 RID: 8977
		// (get) Token: 0x06007CDE RID: 31966 RVA: 0x0014A9A0 File Offset: 0x00148BA0
		// (set) Token: 0x06007CDF RID: 31967 RVA: 0x0014A9A8 File Offset: 0x00148BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HELBEIHMGKK KIOAHBIDMPC
		{
			get
			{
				return this.kIOAHBIDMPC_;
			}
			set
			{
				this.kIOAHBIDMPC_ = value;
			}
		}

		// Token: 0x17002312 RID: 8978
		// (get) Token: 0x06007CE0 RID: 31968 RVA: 0x0014A9B1 File Offset: 0x00148BB1
		// (set) Token: 0x06007CE1 RID: 31969 RVA: 0x0014A9B9 File Offset: 0x00148BB9
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

		// Token: 0x06007CE2 RID: 31970 RVA: 0x0014A9C2 File Offset: 0x00148BC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyAcceptQuizScRsp);
		}

		// Token: 0x06007CE3 RID: 31971 RVA: 0x0014A9D0 File Offset: 0x00148BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyAcceptQuizScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.KIOAHBIDMPC, other.KIOAHBIDMPC) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007CE4 RID: 31972 RVA: 0x0014AA20 File Offset: 0x00148C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.kIOAHBIDMPC_ != null)
			{
				num ^= this.KIOAHBIDMPC.GetHashCode();
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

		// Token: 0x06007CE5 RID: 31973 RVA: 0x0014AA75 File Offset: 0x00148C75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007CE6 RID: 31974 RVA: 0x0014AA7D File Offset: 0x00148C7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007CE7 RID: 31975 RVA: 0x0014AA88 File Offset: 0x00148C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			if (this.kIOAHBIDMPC_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.KIOAHBIDMPC);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007CE8 RID: 31976 RVA: 0x0014AAE4 File Offset: 0x00148CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.kIOAHBIDMPC_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.KIOAHBIDMPC);
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

		// Token: 0x06007CE9 RID: 31977 RVA: 0x0014AB3C File Offset: 0x00148D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyAcceptQuizScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.kIOAHBIDMPC_ != null)
			{
				if (this.kIOAHBIDMPC_ == null)
				{
					this.KIOAHBIDMPC = new HELBEIHMGKK();
				}
				this.KIOAHBIDMPC.MergeFrom(other.KIOAHBIDMPC);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007CEA RID: 31978 RVA: 0x0014ABA4 File Offset: 0x00148DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007CEB RID: 31979 RVA: 0x0014ABB0 File Offset: 0x00148DB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.kIOAHBIDMPC_ == null)
						{
							this.KIOAHBIDMPC = new HELBEIHMGKK();
						}
						input.ReadMessage(this.KIOAHBIDMPC);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002FFD RID: 12285
		private static readonly MessageParser<MonopolyAcceptQuizScRsp> _parser = new MessageParser<MonopolyAcceptQuizScRsp>(() => new MonopolyAcceptQuizScRsp());

		// Token: 0x04002FFE RID: 12286
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FFF RID: 12287
		public const int KIOAHBIDMPCFieldNumber = 9;

		// Token: 0x04003000 RID: 12288
		private HELBEIHMGKK kIOAHBIDMPC_;

		// Token: 0x04003001 RID: 12289
		public const int RetcodeFieldNumber = 2;

		// Token: 0x04003002 RID: 12290
		private uint retcode_;
	}
}
