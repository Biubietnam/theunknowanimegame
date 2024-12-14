using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001201 RID: 4609
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SubmitOfferingItemScRsp : IMessage<SubmitOfferingItemScRsp>, IMessage, IEquatable<SubmitOfferingItemScRsp>, IDeepCloneable<SubmitOfferingItemScRsp>, IBufferMessage
	{
		// Token: 0x17003A1B RID: 14875
		// (get) Token: 0x0600CE00 RID: 52736 RVA: 0x00228C15 File Offset: 0x00226E15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SubmitOfferingItemScRsp> Parser
		{
			get
			{
				return SubmitOfferingItemScRsp._parser;
			}
		}

		// Token: 0x17003A1C RID: 14876
		// (get) Token: 0x0600CE01 RID: 52737 RVA: 0x00228C1C File Offset: 0x00226E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SubmitOfferingItemScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003A1D RID: 14877
		// (get) Token: 0x0600CE02 RID: 52738 RVA: 0x00228C2E File Offset: 0x00226E2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubmitOfferingItemScRsp.Descriptor;
			}
		}

		// Token: 0x0600CE03 RID: 52739 RVA: 0x00228C35 File Offset: 0x00226E35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitOfferingItemScRsp()
		{
		}

		// Token: 0x0600CE04 RID: 52740 RVA: 0x00228C40 File Offset: 0x00226E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitOfferingItemScRsp(SubmitOfferingItemScRsp other) : this()
		{
			this.jLEFMLADEHI_ = ((other.jLEFMLADEHI_ != null) ? other.jLEFMLADEHI_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CE05 RID: 52741 RVA: 0x00228C8C File Offset: 0x00226E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitOfferingItemScRsp Clone()
		{
			return new SubmitOfferingItemScRsp(this);
		}

		// Token: 0x17003A1E RID: 14878
		// (get) Token: 0x0600CE06 RID: 52742 RVA: 0x00228C94 File Offset: 0x00226E94
		// (set) Token: 0x0600CE07 RID: 52743 RVA: 0x00228C9C File Offset: 0x00226E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public POPDHFEBLPG JLEFMLADEHI
		{
			get
			{
				return this.jLEFMLADEHI_;
			}
			set
			{
				this.jLEFMLADEHI_ = value;
			}
		}

		// Token: 0x17003A1F RID: 14879
		// (get) Token: 0x0600CE08 RID: 52744 RVA: 0x00228CA5 File Offset: 0x00226EA5
		// (set) Token: 0x0600CE09 RID: 52745 RVA: 0x00228CAD File Offset: 0x00226EAD
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

		// Token: 0x0600CE0A RID: 52746 RVA: 0x00228CB6 File Offset: 0x00226EB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubmitOfferingItemScRsp);
		}

		// Token: 0x0600CE0B RID: 52747 RVA: 0x00228CC4 File Offset: 0x00226EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SubmitOfferingItemScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.JLEFMLADEHI, other.JLEFMLADEHI) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CE0C RID: 52748 RVA: 0x00228D14 File Offset: 0x00226F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.jLEFMLADEHI_ != null)
			{
				num ^= this.JLEFMLADEHI.GetHashCode();
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

		// Token: 0x0600CE0D RID: 52749 RVA: 0x00228D69 File Offset: 0x00226F69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CE0E RID: 52750 RVA: 0x00228D71 File Offset: 0x00226F71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CE0F RID: 52751 RVA: 0x00228D7C File Offset: 0x00226F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.jLEFMLADEHI_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.JLEFMLADEHI);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CE10 RID: 52752 RVA: 0x00228DD8 File Offset: 0x00226FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.jLEFMLADEHI_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.JLEFMLADEHI);
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

		// Token: 0x0600CE11 RID: 52753 RVA: 0x00228E30 File Offset: 0x00227030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SubmitOfferingItemScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.jLEFMLADEHI_ != null)
			{
				if (this.jLEFMLADEHI_ == null)
				{
					this.JLEFMLADEHI = new POPDHFEBLPG();
				}
				this.JLEFMLADEHI.MergeFrom(other.JLEFMLADEHI);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CE12 RID: 52754 RVA: 0x00228E98 File Offset: 0x00227098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CE13 RID: 52755 RVA: 0x00228EA4 File Offset: 0x002270A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					if (this.jLEFMLADEHI_ == null)
					{
						this.JLEFMLADEHI = new POPDHFEBLPG();
					}
					input.ReadMessage(this.JLEFMLADEHI);
				}
			}
		}

		// Token: 0x04005306 RID: 21254
		private static readonly MessageParser<SubmitOfferingItemScRsp> _parser = new MessageParser<SubmitOfferingItemScRsp>(() => new SubmitOfferingItemScRsp());

		// Token: 0x04005307 RID: 21255
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005308 RID: 21256
		public const int JLEFMLADEHIFieldNumber = 2;

		// Token: 0x04005309 RID: 21257
		private POPDHFEBLPG jLEFMLADEHI_;

		// Token: 0x0400530A RID: 21258
		public const int RetcodeFieldNumber = 12;

		// Token: 0x0400530B RID: 21259
		private uint retcode_;
	}
}
