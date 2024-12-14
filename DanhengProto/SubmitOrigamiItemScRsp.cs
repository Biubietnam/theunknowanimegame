using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001205 RID: 4613
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SubmitOrigamiItemScRsp : IMessage<SubmitOrigamiItemScRsp>, IMessage, IEquatable<SubmitOrigamiItemScRsp>, IDeepCloneable<SubmitOrigamiItemScRsp>, IBufferMessage
	{
		// Token: 0x17003A26 RID: 14886
		// (get) Token: 0x0600CE2C RID: 52780 RVA: 0x00229210 File Offset: 0x00227410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SubmitOrigamiItemScRsp> Parser
		{
			get
			{
				return SubmitOrigamiItemScRsp._parser;
			}
		}

		// Token: 0x17003A27 RID: 14887
		// (get) Token: 0x0600CE2D RID: 52781 RVA: 0x00229217 File Offset: 0x00227417
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SubmitOrigamiItemScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003A28 RID: 14888
		// (get) Token: 0x0600CE2E RID: 52782 RVA: 0x00229229 File Offset: 0x00227429
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubmitOrigamiItemScRsp.Descriptor;
			}
		}

		// Token: 0x0600CE2F RID: 52783 RVA: 0x00229230 File Offset: 0x00227430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitOrigamiItemScRsp()
		{
		}

		// Token: 0x0600CE30 RID: 52784 RVA: 0x00229238 File Offset: 0x00227438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitOrigamiItemScRsp(SubmitOrigamiItemScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.hFICIPFFDEB_ = other.hFICIPFFDEB_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CE31 RID: 52785 RVA: 0x00229269 File Offset: 0x00227469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitOrigamiItemScRsp Clone()
		{
			return new SubmitOrigamiItemScRsp(this);
		}

		// Token: 0x17003A29 RID: 14889
		// (get) Token: 0x0600CE32 RID: 52786 RVA: 0x00229271 File Offset: 0x00227471
		// (set) Token: 0x0600CE33 RID: 52787 RVA: 0x00229279 File Offset: 0x00227479
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

		// Token: 0x17003A2A RID: 14890
		// (get) Token: 0x0600CE34 RID: 52788 RVA: 0x00229282 File Offset: 0x00227482
		// (set) Token: 0x0600CE35 RID: 52789 RVA: 0x0022928A File Offset: 0x0022748A
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

		// Token: 0x0600CE36 RID: 52790 RVA: 0x00229293 File Offset: 0x00227493
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubmitOrigamiItemScRsp);
		}

		// Token: 0x0600CE37 RID: 52791 RVA: 0x002292A1 File Offset: 0x002274A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SubmitOrigamiItemScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.HFICIPFFDEB == other.HFICIPFFDEB && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CE38 RID: 52792 RVA: 0x002292E0 File Offset: 0x002274E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
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

		// Token: 0x0600CE39 RID: 52793 RVA: 0x00229338 File Offset: 0x00227538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CE3A RID: 52794 RVA: 0x00229340 File Offset: 0x00227540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CE3B RID: 52795 RVA: 0x0022934C File Offset: 0x0022754C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HFICIPFFDEB != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.HFICIPFFDEB);
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

		// Token: 0x0600CE3C RID: 52796 RVA: 0x002293A8 File Offset: 0x002275A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
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

		// Token: 0x0600CE3D RID: 52797 RVA: 0x00229400 File Offset: 0x00227600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SubmitOrigamiItemScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.HFICIPFFDEB != 0U)
			{
				this.HFICIPFFDEB = other.HFICIPFFDEB;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CE3E RID: 52798 RVA: 0x00229450 File Offset: 0x00227650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CE3F RID: 52799 RVA: 0x0022945C File Offset: 0x0022765C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
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
					this.HFICIPFFDEB = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005312 RID: 21266
		private static readonly MessageParser<SubmitOrigamiItemScRsp> _parser = new MessageParser<SubmitOrigamiItemScRsp>(() => new SubmitOrigamiItemScRsp());

		// Token: 0x04005313 RID: 21267
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005314 RID: 21268
		public const int RetcodeFieldNumber = 12;

		// Token: 0x04005315 RID: 21269
		private uint retcode_;

		// Token: 0x04005316 RID: 21270
		public const int HFICIPFFDEBFieldNumber = 9;

		// Token: 0x04005317 RID: 21271
		private uint hFICIPFFDEB_;
	}
}
