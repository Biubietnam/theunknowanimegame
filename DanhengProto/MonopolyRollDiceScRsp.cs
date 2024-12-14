using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B6D RID: 2925
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyRollDiceScRsp : IMessage<MonopolyRollDiceScRsp>, IMessage, IEquatable<MonopolyRollDiceScRsp>, IDeepCloneable<MonopolyRollDiceScRsp>, IBufferMessage
	{
		// Token: 0x1700243F RID: 9279
		// (get) Token: 0x0600816C RID: 33132 RVA: 0x001550BC File Offset: 0x001532BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyRollDiceScRsp> Parser
		{
			get
			{
				return MonopolyRollDiceScRsp._parser;
			}
		}

		// Token: 0x17002440 RID: 9280
		// (get) Token: 0x0600816D RID: 33133 RVA: 0x001550C3 File Offset: 0x001532C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyRollDiceScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002441 RID: 9281
		// (get) Token: 0x0600816E RID: 33134 RVA: 0x001550D5 File Offset: 0x001532D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyRollDiceScRsp.Descriptor;
			}
		}

		// Token: 0x0600816F RID: 33135 RVA: 0x001550DC File Offset: 0x001532DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyRollDiceScRsp()
		{
		}

		// Token: 0x06008170 RID: 33136 RVA: 0x001550E4 File Offset: 0x001532E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyRollDiceScRsp(MonopolyRollDiceScRsp other) : this()
		{
			this.mEDNCALHCHF_ = other.mEDNCALHCHF_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008171 RID: 33137 RVA: 0x00155115 File Offset: 0x00153315
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyRollDiceScRsp Clone()
		{
			return new MonopolyRollDiceScRsp(this);
		}

		// Token: 0x17002442 RID: 9282
		// (get) Token: 0x06008172 RID: 33138 RVA: 0x0015511D File Offset: 0x0015331D
		// (set) Token: 0x06008173 RID: 33139 RVA: 0x00155125 File Offset: 0x00153325
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MEDNCALHCHF
		{
			get
			{
				return this.mEDNCALHCHF_;
			}
			set
			{
				this.mEDNCALHCHF_ = value;
			}
		}

		// Token: 0x17002443 RID: 9283
		// (get) Token: 0x06008174 RID: 33140 RVA: 0x0015512E File Offset: 0x0015332E
		// (set) Token: 0x06008175 RID: 33141 RVA: 0x00155136 File Offset: 0x00153336
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

		// Token: 0x06008176 RID: 33142 RVA: 0x0015513F File Offset: 0x0015333F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyRollDiceScRsp);
		}

		// Token: 0x06008177 RID: 33143 RVA: 0x0015514D File Offset: 0x0015334D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyRollDiceScRsp other)
		{
			return other != null && (other == this || (this.MEDNCALHCHF == other.MEDNCALHCHF && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008178 RID: 33144 RVA: 0x0015518C File Offset: 0x0015338C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MEDNCALHCHF != 0U)
			{
				num ^= this.MEDNCALHCHF.GetHashCode();
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

		// Token: 0x06008179 RID: 33145 RVA: 0x001551E4 File Offset: 0x001533E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600817A RID: 33146 RVA: 0x001551EC File Offset: 0x001533EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600817B RID: 33147 RVA: 0x001551F8 File Offset: 0x001533F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			if (this.MEDNCALHCHF != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.MEDNCALHCHF);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600817C RID: 33148 RVA: 0x00155250 File Offset: 0x00153450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MEDNCALHCHF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MEDNCALHCHF);
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

		// Token: 0x0600817D RID: 33149 RVA: 0x001552A8 File Offset: 0x001534A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyRollDiceScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MEDNCALHCHF != 0U)
			{
				this.MEDNCALHCHF = other.MEDNCALHCHF;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600817E RID: 33150 RVA: 0x001552F8 File Offset: 0x001534F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600817F RID: 33151 RVA: 0x00155304 File Offset: 0x00153504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MEDNCALHCHF = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003165 RID: 12645
		private static readonly MessageParser<MonopolyRollDiceScRsp> _parser = new MessageParser<MonopolyRollDiceScRsp>(() => new MonopolyRollDiceScRsp());

		// Token: 0x04003166 RID: 12646
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003167 RID: 12647
		public const int MEDNCALHCHFFieldNumber = 4;

		// Token: 0x04003168 RID: 12648
		private uint mEDNCALHCHF_;

		// Token: 0x04003169 RID: 12649
		public const int RetcodeFieldNumber = 1;

		// Token: 0x0400316A RID: 12650
		private uint retcode_;
	}
}
