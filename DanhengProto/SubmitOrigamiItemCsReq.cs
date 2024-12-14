using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001203 RID: 4611
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SubmitOrigamiItemCsReq : IMessage<SubmitOrigamiItemCsReq>, IMessage, IEquatable<SubmitOrigamiItemCsReq>, IDeepCloneable<SubmitOrigamiItemCsReq>, IBufferMessage
	{
		// Token: 0x17003A21 RID: 14881
		// (get) Token: 0x0600CE17 RID: 52759 RVA: 0x00228F98 File Offset: 0x00227198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SubmitOrigamiItemCsReq> Parser
		{
			get
			{
				return SubmitOrigamiItemCsReq._parser;
			}
		}

		// Token: 0x17003A22 RID: 14882
		// (get) Token: 0x0600CE18 RID: 52760 RVA: 0x00228F9F File Offset: 0x0022719F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SubmitOrigamiItemCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003A23 RID: 14883
		// (get) Token: 0x0600CE19 RID: 52761 RVA: 0x00228FB1 File Offset: 0x002271B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubmitOrigamiItemCsReq.Descriptor;
			}
		}

		// Token: 0x0600CE1A RID: 52762 RVA: 0x00228FB8 File Offset: 0x002271B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitOrigamiItemCsReq()
		{
		}

		// Token: 0x0600CE1B RID: 52763 RVA: 0x00228FC0 File Offset: 0x002271C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitOrigamiItemCsReq(SubmitOrigamiItemCsReq other) : this()
		{
			this.hFICIPFFDEB_ = other.hFICIPFFDEB_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CE1C RID: 52764 RVA: 0x00228FE5 File Offset: 0x002271E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitOrigamiItemCsReq Clone()
		{
			return new SubmitOrigamiItemCsReq(this);
		}

		// Token: 0x17003A24 RID: 14884
		// (get) Token: 0x0600CE1D RID: 52765 RVA: 0x00228FED File Offset: 0x002271ED
		// (set) Token: 0x0600CE1E RID: 52766 RVA: 0x00228FF5 File Offset: 0x002271F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HFICIPFFDEB
		{
			get
			{
				return this.hFICIPFFDEB_;
			}
			set
			{
				this.hFICIPFFDEB_ = value;
			}
		}

		// Token: 0x0600CE1F RID: 52767 RVA: 0x00228FFE File Offset: 0x002271FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubmitOrigamiItemCsReq);
		}

		// Token: 0x0600CE20 RID: 52768 RVA: 0x0022900C File Offset: 0x0022720C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SubmitOrigamiItemCsReq other)
		{
			return other != null && (other == this || (this.HFICIPFFDEB == other.HFICIPFFDEB && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CE21 RID: 52769 RVA: 0x0022903C File Offset: 0x0022723C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HFICIPFFDEB != 0U)
			{
				num ^= this.HFICIPFFDEB.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CE22 RID: 52770 RVA: 0x0022907B File Offset: 0x0022727B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CE23 RID: 52771 RVA: 0x00229083 File Offset: 0x00227283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CE24 RID: 52772 RVA: 0x0022908C File Offset: 0x0022728C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HFICIPFFDEB != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.HFICIPFFDEB);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CE25 RID: 52773 RVA: 0x002290C0 File Offset: 0x002272C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HFICIPFFDEB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HFICIPFFDEB);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CE26 RID: 52774 RVA: 0x002290FE File Offset: 0x002272FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SubmitOrigamiItemCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HFICIPFFDEB != 0U)
			{
				this.HFICIPFFDEB = other.HFICIPFFDEB;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CE27 RID: 52775 RVA: 0x0022912F File Offset: 0x0022732F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CE28 RID: 52776 RVA: 0x00229138 File Offset: 0x00227338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.HFICIPFFDEB = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400530D RID: 21261
		private static readonly MessageParser<SubmitOrigamiItemCsReq> _parser = new MessageParser<SubmitOrigamiItemCsReq>(() => new SubmitOrigamiItemCsReq());

		// Token: 0x0400530E RID: 21262
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400530F RID: 21263
		public const int HFICIPFFDEBFieldNumber = 6;

		// Token: 0x04005310 RID: 21264
		private uint hFICIPFFDEB_;
	}
}
