using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B53 RID: 2899
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyGuessBuyInformationScRsp : IMessage<MonopolyGuessBuyInformationScRsp>, IMessage, IEquatable<MonopolyGuessBuyInformationScRsp>, IDeepCloneable<MonopolyGuessBuyInformationScRsp>, IBufferMessage
	{
		// Token: 0x170023F6 RID: 9206
		// (get) Token: 0x0600804F RID: 32847 RVA: 0x00152994 File Offset: 0x00150B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyGuessBuyInformationScRsp> Parser
		{
			get
			{
				return MonopolyGuessBuyInformationScRsp._parser;
			}
		}

		// Token: 0x170023F7 RID: 9207
		// (get) Token: 0x06008050 RID: 32848 RVA: 0x0015299B File Offset: 0x00150B9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyGuessBuyInformationScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170023F8 RID: 9208
		// (get) Token: 0x06008051 RID: 32849 RVA: 0x001529AD File Offset: 0x00150BAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyGuessBuyInformationScRsp.Descriptor;
			}
		}

		// Token: 0x06008052 RID: 32850 RVA: 0x001529B4 File Offset: 0x00150BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGuessBuyInformationScRsp()
		{
		}

		// Token: 0x06008053 RID: 32851 RVA: 0x001529BC File Offset: 0x00150BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGuessBuyInformationScRsp(MonopolyGuessBuyInformationScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008054 RID: 32852 RVA: 0x001529E1 File Offset: 0x00150BE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGuessBuyInformationScRsp Clone()
		{
			return new MonopolyGuessBuyInformationScRsp(this);
		}

		// Token: 0x170023F9 RID: 9209
		// (get) Token: 0x06008055 RID: 32853 RVA: 0x001529E9 File Offset: 0x00150BE9
		// (set) Token: 0x06008056 RID: 32854 RVA: 0x001529F1 File Offset: 0x00150BF1
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

		// Token: 0x06008057 RID: 32855 RVA: 0x001529FA File Offset: 0x00150BFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyGuessBuyInformationScRsp);
		}

		// Token: 0x06008058 RID: 32856 RVA: 0x00152A08 File Offset: 0x00150C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyGuessBuyInformationScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008059 RID: 32857 RVA: 0x00152A38 File Offset: 0x00150C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600805A RID: 32858 RVA: 0x00152A77 File Offset: 0x00150C77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600805B RID: 32859 RVA: 0x00152A7F File Offset: 0x00150C7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600805C RID: 32860 RVA: 0x00152A88 File Offset: 0x00150C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600805D RID: 32861 RVA: 0x00152ABC File Offset: 0x00150CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600805E RID: 32862 RVA: 0x00152AFA File Offset: 0x00150CFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyGuessBuyInformationScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600805F RID: 32863 RVA: 0x00152B2B File Offset: 0x00150D2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008060 RID: 32864 RVA: 0x00152B34 File Offset: 0x00150D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003110 RID: 12560
		private static readonly MessageParser<MonopolyGuessBuyInformationScRsp> _parser = new MessageParser<MonopolyGuessBuyInformationScRsp>(() => new MonopolyGuessBuyInformationScRsp());

		// Token: 0x04003111 RID: 12561
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003112 RID: 12562
		public const int RetcodeFieldNumber = 5;

		// Token: 0x04003113 RID: 12563
		private uint retcode_;
	}
}
