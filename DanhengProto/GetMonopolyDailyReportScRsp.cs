using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200072B RID: 1835
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetMonopolyDailyReportScRsp : IMessage<GetMonopolyDailyReportScRsp>, IMessage, IEquatable<GetMonopolyDailyReportScRsp>, IDeepCloneable<GetMonopolyDailyReportScRsp>, IBufferMessage
	{
		// Token: 0x1700173C RID: 5948
		// (get) Token: 0x060051FF RID: 20991 RVA: 0x000DCCC1 File Offset: 0x000DAEC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetMonopolyDailyReportScRsp> Parser
		{
			get
			{
				return GetMonopolyDailyReportScRsp._parser;
			}
		}

		// Token: 0x1700173D RID: 5949
		// (get) Token: 0x06005200 RID: 20992 RVA: 0x000DCCC8 File Offset: 0x000DAEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetMonopolyDailyReportScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700173E RID: 5950
		// (get) Token: 0x06005201 RID: 20993 RVA: 0x000DCCDA File Offset: 0x000DAEDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetMonopolyDailyReportScRsp.Descriptor;
			}
		}

		// Token: 0x06005202 RID: 20994 RVA: 0x000DCCE1 File Offset: 0x000DAEE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMonopolyDailyReportScRsp()
		{
		}

		// Token: 0x06005203 RID: 20995 RVA: 0x000DCCEC File Offset: 0x000DAEEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMonopolyDailyReportScRsp(GetMonopolyDailyReportScRsp other) : this()
		{
			this.pCOEFKDDBOE_ = ((other.pCOEFKDDBOE_ != null) ? other.pCOEFKDDBOE_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005204 RID: 20996 RVA: 0x000DCD38 File Offset: 0x000DAF38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMonopolyDailyReportScRsp Clone()
		{
			return new GetMonopolyDailyReportScRsp(this);
		}

		// Token: 0x1700173F RID: 5951
		// (get) Token: 0x06005205 RID: 20997 RVA: 0x000DCD40 File Offset: 0x000DAF40
		// (set) Token: 0x06005206 RID: 20998 RVA: 0x000DCD48 File Offset: 0x000DAF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OEEFPPBEAOF PCOEFKDDBOE
		{
			get
			{
				return this.pCOEFKDDBOE_;
			}
			set
			{
				this.pCOEFKDDBOE_ = value;
			}
		}

		// Token: 0x17001740 RID: 5952
		// (get) Token: 0x06005207 RID: 20999 RVA: 0x000DCD51 File Offset: 0x000DAF51
		// (set) Token: 0x06005208 RID: 21000 RVA: 0x000DCD59 File Offset: 0x000DAF59
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

		// Token: 0x06005209 RID: 21001 RVA: 0x000DCD62 File Offset: 0x000DAF62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetMonopolyDailyReportScRsp);
		}

		// Token: 0x0600520A RID: 21002 RVA: 0x000DCD70 File Offset: 0x000DAF70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetMonopolyDailyReportScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.PCOEFKDDBOE, other.PCOEFKDDBOE) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600520B RID: 21003 RVA: 0x000DCDC0 File Offset: 0x000DAFC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.pCOEFKDDBOE_ != null)
			{
				num ^= this.PCOEFKDDBOE.GetHashCode();
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

		// Token: 0x0600520C RID: 21004 RVA: 0x000DCE15 File Offset: 0x000DB015
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600520D RID: 21005 RVA: 0x000DCE1D File Offset: 0x000DB01D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600520E RID: 21006 RVA: 0x000DCE28 File Offset: 0x000DB028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.pCOEFKDDBOE_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.PCOEFKDDBOE);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600520F RID: 21007 RVA: 0x000DCE84 File Offset: 0x000DB084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.pCOEFKDDBOE_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PCOEFKDDBOE);
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

		// Token: 0x06005210 RID: 21008 RVA: 0x000DCEDC File Offset: 0x000DB0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetMonopolyDailyReportScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.pCOEFKDDBOE_ != null)
			{
				if (this.pCOEFKDDBOE_ == null)
				{
					this.PCOEFKDDBOE = new OEEFPPBEAOF();
				}
				this.PCOEFKDDBOE.MergeFrom(other.PCOEFKDDBOE);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005211 RID: 21009 RVA: 0x000DCF44 File Offset: 0x000DB144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005212 RID: 21010 RVA: 0x000DCF50 File Offset: 0x000DB150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 42U)
				{
					if (num != 80U)
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
					if (this.pCOEFKDDBOE_ == null)
					{
						this.PCOEFKDDBOE = new OEEFPPBEAOF();
					}
					input.ReadMessage(this.PCOEFKDDBOE);
				}
			}
		}

		// Token: 0x04002041 RID: 8257
		private static readonly MessageParser<GetMonopolyDailyReportScRsp> _parser = new MessageParser<GetMonopolyDailyReportScRsp>(() => new GetMonopolyDailyReportScRsp());

		// Token: 0x04002042 RID: 8258
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002043 RID: 8259
		public const int PCOEFKDDBOEFieldNumber = 5;

		// Token: 0x04002044 RID: 8260
		private OEEFPPBEAOF pCOEFKDDBOE_;

		// Token: 0x04002045 RID: 8261
		public const int RetcodeFieldNumber = 10;

		// Token: 0x04002046 RID: 8262
		private uint retcode_;
	}
}
