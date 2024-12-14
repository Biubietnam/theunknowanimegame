using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AB7 RID: 2743
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MBHPHEIJPMG : IMessage<MBHPHEIJPMG>, IMessage, IEquatable<MBHPHEIJPMG>, IDeepCloneable<MBHPHEIJPMG>, IBufferMessage
	{
		// Token: 0x17002228 RID: 8744
		// (get) Token: 0x060079A4 RID: 31140 RVA: 0x001425A8 File Offset: 0x001407A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MBHPHEIJPMG> Parser
		{
			get
			{
				return MBHPHEIJPMG._parser;
			}
		}

		// Token: 0x17002229 RID: 8745
		// (get) Token: 0x060079A5 RID: 31141 RVA: 0x001425AF File Offset: 0x001407AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MBHPHEIJPMGReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700222A RID: 8746
		// (get) Token: 0x060079A6 RID: 31142 RVA: 0x001425C1 File Offset: 0x001407C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MBHPHEIJPMG.Descriptor;
			}
		}

		// Token: 0x060079A7 RID: 31143 RVA: 0x001425C8 File Offset: 0x001407C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MBHPHEIJPMG()
		{
		}

		// Token: 0x060079A8 RID: 31144 RVA: 0x001425D0 File Offset: 0x001407D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MBHPHEIJPMG(MBHPHEIJPMG other) : this()
		{
			this.gachaRandom_ = other.gachaRandom_;
			this.gFBGCHIMNPF_ = other.gFBGCHIMNPF_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060079A9 RID: 31145 RVA: 0x00142601 File Offset: 0x00140801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MBHPHEIJPMG Clone()
		{
			return new MBHPHEIJPMG(this);
		}

		// Token: 0x1700222B RID: 8747
		// (get) Token: 0x060079AA RID: 31146 RVA: 0x00142609 File Offset: 0x00140809
		// (set) Token: 0x060079AB RID: 31147 RVA: 0x00142611 File Offset: 0x00140811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GachaRandom
		{
			get
			{
				return this.gachaRandom_;
			}
			set
			{
				this.gachaRandom_ = value;
			}
		}

		// Token: 0x1700222C RID: 8748
		// (get) Token: 0x060079AC RID: 31148 RVA: 0x0014261A File Offset: 0x0014081A
		// (set) Token: 0x060079AD RID: 31149 RVA: 0x00142622 File Offset: 0x00140822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool GFBGCHIMNPF
		{
			get
			{
				return this.gFBGCHIMNPF_;
			}
			set
			{
				this.gFBGCHIMNPF_ = value;
			}
		}

		// Token: 0x060079AE RID: 31150 RVA: 0x0014262B File Offset: 0x0014082B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MBHPHEIJPMG);
		}

		// Token: 0x060079AF RID: 31151 RVA: 0x00142639 File Offset: 0x00140839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MBHPHEIJPMG other)
		{
			return other != null && (other == this || (this.GachaRandom == other.GachaRandom && this.GFBGCHIMNPF == other.GFBGCHIMNPF && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060079B0 RID: 31152 RVA: 0x00142678 File Offset: 0x00140878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GachaRandom != 0U)
			{
				num ^= this.GachaRandom.GetHashCode();
			}
			if (this.GFBGCHIMNPF)
			{
				num ^= this.GFBGCHIMNPF.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060079B1 RID: 31153 RVA: 0x001426D0 File Offset: 0x001408D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060079B2 RID: 31154 RVA: 0x001426D8 File Offset: 0x001408D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060079B3 RID: 31155 RVA: 0x001426E4 File Offset: 0x001408E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GachaRandom != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.GachaRandom);
			}
			if (this.GFBGCHIMNPF)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.GFBGCHIMNPF);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060079B4 RID: 31156 RVA: 0x00142740 File Offset: 0x00140940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GachaRandom != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GachaRandom);
			}
			if (this.GFBGCHIMNPF)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060079B5 RID: 31157 RVA: 0x0014278C File Offset: 0x0014098C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MBHPHEIJPMG other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GachaRandom != 0U)
			{
				this.GachaRandom = other.GachaRandom;
			}
			if (other.GFBGCHIMNPF)
			{
				this.GFBGCHIMNPF = other.GFBGCHIMNPF;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060079B6 RID: 31158 RVA: 0x001427DC File Offset: 0x001409DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060079B7 RID: 31159 RVA: 0x001427E8 File Offset: 0x001409E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.GFBGCHIMNPF = input.ReadBool();
					}
				}
				else
				{
					this.GachaRandom = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002EB1 RID: 11953
		private static readonly MessageParser<MBHPHEIJPMG> _parser = new MessageParser<MBHPHEIJPMG>(() => new MBHPHEIJPMG());

		// Token: 0x04002EB2 RID: 11954
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002EB3 RID: 11955
		public const int GachaRandomFieldNumber = 11;

		// Token: 0x04002EB4 RID: 11956
		private uint gachaRandom_;

		// Token: 0x04002EB5 RID: 11957
		public const int GFBGCHIMNPFFieldNumber = 15;

		// Token: 0x04002EB6 RID: 11958
		private bool gFBGCHIMNPF_;
	}
}
