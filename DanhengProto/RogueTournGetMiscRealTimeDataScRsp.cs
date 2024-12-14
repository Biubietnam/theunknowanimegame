using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FCF RID: 4047
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournGetMiscRealTimeDataScRsp : IMessage<RogueTournGetMiscRealTimeDataScRsp>, IMessage, IEquatable<RogueTournGetMiscRealTimeDataScRsp>, IDeepCloneable<RogueTournGetMiscRealTimeDataScRsp>, IBufferMessage
	{
		// Token: 0x170032CD RID: 13005
		// (get) Token: 0x0600B445 RID: 46149 RVA: 0x001E3C77 File Offset: 0x001E1E77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournGetMiscRealTimeDataScRsp> Parser
		{
			get
			{
				return RogueTournGetMiscRealTimeDataScRsp._parser;
			}
		}

		// Token: 0x170032CE RID: 13006
		// (get) Token: 0x0600B446 RID: 46150 RVA: 0x001E3C7E File Offset: 0x001E1E7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournGetMiscRealTimeDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170032CF RID: 13007
		// (get) Token: 0x0600B447 RID: 46151 RVA: 0x001E3C90 File Offset: 0x001E1E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournGetMiscRealTimeDataScRsp.Descriptor;
			}
		}

		// Token: 0x0600B448 RID: 46152 RVA: 0x001E3C97 File Offset: 0x001E1E97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGetMiscRealTimeDataScRsp()
		{
		}

		// Token: 0x0600B449 RID: 46153 RVA: 0x001E3CA0 File Offset: 0x001E1EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGetMiscRealTimeDataScRsp(RogueTournGetMiscRealTimeDataScRsp other) : this()
		{
			this.nFEIIDHDENB_ = ((other.nFEIIDHDENB_ != null) ? other.nFEIIDHDENB_.Clone() : null);
			this.dPAFCHMPEJC_ = ((other.dPAFCHMPEJC_ != null) ? other.dPAFCHMPEJC_.Clone() : null);
			this.lAIOKLJNPFO_ = ((other.lAIOKLJNPFO_ != null) ? other.lAIOKLJNPFO_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B44A RID: 46154 RVA: 0x001E3D24 File Offset: 0x001E1F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGetMiscRealTimeDataScRsp Clone()
		{
			return new RogueTournGetMiscRealTimeDataScRsp(this);
		}

		// Token: 0x170032D0 RID: 13008
		// (get) Token: 0x0600B44B RID: 46155 RVA: 0x001E3D2C File Offset: 0x001E1F2C
		// (set) Token: 0x0600B44C RID: 46156 RVA: 0x001E3D34 File Offset: 0x001E1F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PDLIMIHCKFI NFEIIDHDENB
		{
			get
			{
				return this.nFEIIDHDENB_;
			}
			set
			{
				this.nFEIIDHDENB_ = value;
			}
		}

		// Token: 0x170032D1 RID: 13009
		// (get) Token: 0x0600B44D RID: 46157 RVA: 0x001E3D3D File Offset: 0x001E1F3D
		// (set) Token: 0x0600B44E RID: 46158 RVA: 0x001E3D45 File Offset: 0x001E1F45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PFJOGHHDEAH DPAFCHMPEJC
		{
			get
			{
				return this.dPAFCHMPEJC_;
			}
			set
			{
				this.dPAFCHMPEJC_ = value;
			}
		}

		// Token: 0x170032D2 RID: 13010
		// (get) Token: 0x0600B44F RID: 46159 RVA: 0x001E3D4E File Offset: 0x001E1F4E
		// (set) Token: 0x0600B450 RID: 46160 RVA: 0x001E3D56 File Offset: 0x001E1F56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KJDLBJHAPMJ LAIOKLJNPFO
		{
			get
			{
				return this.lAIOKLJNPFO_;
			}
			set
			{
				this.lAIOKLJNPFO_ = value;
			}
		}

		// Token: 0x170032D3 RID: 13011
		// (get) Token: 0x0600B451 RID: 46161 RVA: 0x001E3D5F File Offset: 0x001E1F5F
		// (set) Token: 0x0600B452 RID: 46162 RVA: 0x001E3D67 File Offset: 0x001E1F67
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

		// Token: 0x0600B453 RID: 46163 RVA: 0x001E3D70 File Offset: 0x001E1F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournGetMiscRealTimeDataScRsp);
		}

		// Token: 0x0600B454 RID: 46164 RVA: 0x001E3D80 File Offset: 0x001E1F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournGetMiscRealTimeDataScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.NFEIIDHDENB, other.NFEIIDHDENB) && object.Equals(this.DPAFCHMPEJC, other.DPAFCHMPEJC) && object.Equals(this.LAIOKLJNPFO, other.LAIOKLJNPFO) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B455 RID: 46165 RVA: 0x001E3DF8 File Offset: 0x001E1FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.nFEIIDHDENB_ != null)
			{
				num ^= this.NFEIIDHDENB.GetHashCode();
			}
			if (this.dPAFCHMPEJC_ != null)
			{
				num ^= this.DPAFCHMPEJC.GetHashCode();
			}
			if (this.lAIOKLJNPFO_ != null)
			{
				num ^= this.LAIOKLJNPFO.GetHashCode();
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

		// Token: 0x0600B456 RID: 46166 RVA: 0x001E3E79 File Offset: 0x001E2079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B457 RID: 46167 RVA: 0x001E3E81 File Offset: 0x001E2081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B458 RID: 46168 RVA: 0x001E3E8C File Offset: 0x001E208C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.nFEIIDHDENB_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.NFEIIDHDENB);
			}
			if (this.lAIOKLJNPFO_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.LAIOKLJNPFO);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			if (this.dPAFCHMPEJC_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.DPAFCHMPEJC);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B459 RID: 46169 RVA: 0x001E3F20 File Offset: 0x001E2120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.nFEIIDHDENB_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NFEIIDHDENB);
			}
			if (this.dPAFCHMPEJC_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DPAFCHMPEJC);
			}
			if (this.lAIOKLJNPFO_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LAIOKLJNPFO);
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

		// Token: 0x0600B45A RID: 46170 RVA: 0x001E3FA8 File Offset: 0x001E21A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournGetMiscRealTimeDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.nFEIIDHDENB_ != null)
			{
				if (this.nFEIIDHDENB_ == null)
				{
					this.NFEIIDHDENB = new PDLIMIHCKFI();
				}
				this.NFEIIDHDENB.MergeFrom(other.NFEIIDHDENB);
			}
			if (other.dPAFCHMPEJC_ != null)
			{
				if (this.dPAFCHMPEJC_ == null)
				{
					this.DPAFCHMPEJC = new PFJOGHHDEAH();
				}
				this.DPAFCHMPEJC.MergeFrom(other.DPAFCHMPEJC);
			}
			if (other.lAIOKLJNPFO_ != null)
			{
				if (this.lAIOKLJNPFO_ == null)
				{
					this.LAIOKLJNPFO = new KJDLBJHAPMJ();
				}
				this.LAIOKLJNPFO.MergeFrom(other.LAIOKLJNPFO);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B45B RID: 46171 RVA: 0x001E4068 File Offset: 0x001E2268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B45C RID: 46172 RVA: 0x001E4074 File Offset: 0x001E2274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 34U)
				{
					if (num == 10U)
					{
						if (this.nFEIIDHDENB_ == null)
						{
							this.NFEIIDHDENB = new PDLIMIHCKFI();
						}
						input.ReadMessage(this.NFEIIDHDENB);
						continue;
					}
					if (num == 34U)
					{
						if (this.lAIOKLJNPFO_ == null)
						{
							this.LAIOKLJNPFO = new KJDLBJHAPMJ();
						}
						input.ReadMessage(this.LAIOKLJNPFO);
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 90U)
					{
						if (this.dPAFCHMPEJC_ == null)
						{
							this.DPAFCHMPEJC = new PFJOGHHDEAH();
						}
						input.ReadMessage(this.DPAFCHMPEJC);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004916 RID: 18710
		private static readonly MessageParser<RogueTournGetMiscRealTimeDataScRsp> _parser = new MessageParser<RogueTournGetMiscRealTimeDataScRsp>(() => new RogueTournGetMiscRealTimeDataScRsp());

		// Token: 0x04004917 RID: 18711
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004918 RID: 18712
		public const int NFEIIDHDENBFieldNumber = 1;

		// Token: 0x04004919 RID: 18713
		private PDLIMIHCKFI nFEIIDHDENB_;

		// Token: 0x0400491A RID: 18714
		public const int DPAFCHMPEJCFieldNumber = 11;

		// Token: 0x0400491B RID: 18715
		private PFJOGHHDEAH dPAFCHMPEJC_;

		// Token: 0x0400491C RID: 18716
		public const int LAIOKLJNPFOFieldNumber = 4;

		// Token: 0x0400491D RID: 18717
		private KJDLBJHAPMJ lAIOKLJNPFO_;

		// Token: 0x0400491E RID: 18718
		public const int RetcodeFieldNumber = 5;

		// Token: 0x0400491F RID: 18719
		private uint retcode_;
	}
}
