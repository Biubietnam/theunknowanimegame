using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A1D RID: 2589
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LKJMDOAHGIN : IMessage<LKJMDOAHGIN>, IMessage, IEquatable<LKJMDOAHGIN>, IDeepCloneable<LKJMDOAHGIN>, IBufferMessage
	{
		// Token: 0x17002062 RID: 8290
		// (get) Token: 0x06007317 RID: 29463 RVA: 0x001329E0 File Offset: 0x00130BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LKJMDOAHGIN> Parser
		{
			get
			{
				return LKJMDOAHGIN._parser;
			}
		}

		// Token: 0x17002063 RID: 8291
		// (get) Token: 0x06007318 RID: 29464 RVA: 0x001329E7 File Offset: 0x00130BE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LKJMDOAHGINReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002064 RID: 8292
		// (get) Token: 0x06007319 RID: 29465 RVA: 0x001329F9 File Offset: 0x00130BF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LKJMDOAHGIN.Descriptor;
			}
		}

		// Token: 0x0600731A RID: 29466 RVA: 0x00132A00 File Offset: 0x00130C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LKJMDOAHGIN()
		{
		}

		// Token: 0x0600731B RID: 29467 RVA: 0x00132A08 File Offset: 0x00130C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LKJMDOAHGIN(LKJMDOAHGIN other) : this()
		{
			this.fNLJPOJFHOA_ = other.fNLJPOJFHOA_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600731C RID: 29468 RVA: 0x00132A2D File Offset: 0x00130C2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LKJMDOAHGIN Clone()
		{
			return new LKJMDOAHGIN(this);
		}

		// Token: 0x17002065 RID: 8293
		// (get) Token: 0x0600731D RID: 29469 RVA: 0x00132A35 File Offset: 0x00130C35
		// (set) Token: 0x0600731E RID: 29470 RVA: 0x00132A3D File Offset: 0x00130C3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FNLJPOJFHOA
		{
			get
			{
				return this.fNLJPOJFHOA_;
			}
			set
			{
				this.fNLJPOJFHOA_ = value;
			}
		}

		// Token: 0x0600731F RID: 29471 RVA: 0x00132A46 File Offset: 0x00130C46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LKJMDOAHGIN);
		}

		// Token: 0x06007320 RID: 29472 RVA: 0x00132A54 File Offset: 0x00130C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LKJMDOAHGIN other)
		{
			return other != null && (other == this || (this.FNLJPOJFHOA == other.FNLJPOJFHOA && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007321 RID: 29473 RVA: 0x00132A84 File Offset: 0x00130C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FNLJPOJFHOA != 0U)
			{
				num ^= this.FNLJPOJFHOA.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007322 RID: 29474 RVA: 0x00132AC3 File Offset: 0x00130CC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007323 RID: 29475 RVA: 0x00132ACB File Offset: 0x00130CCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007324 RID: 29476 RVA: 0x00132AD4 File Offset: 0x00130CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FNLJPOJFHOA != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.FNLJPOJFHOA);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007325 RID: 29477 RVA: 0x00132B08 File Offset: 0x00130D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FNLJPOJFHOA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FNLJPOJFHOA);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007326 RID: 29478 RVA: 0x00132B46 File Offset: 0x00130D46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LKJMDOAHGIN other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FNLJPOJFHOA != 0U)
			{
				this.FNLJPOJFHOA = other.FNLJPOJFHOA;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007327 RID: 29479 RVA: 0x00132B77 File Offset: 0x00130D77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007328 RID: 29480 RVA: 0x00132B80 File Offset: 0x00130D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.FNLJPOJFHOA = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002C54 RID: 11348
		private static readonly MessageParser<LKJMDOAHGIN> _parser = new MessageParser<LKJMDOAHGIN>(() => new LKJMDOAHGIN());

		// Token: 0x04002C55 RID: 11349
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C56 RID: 11350
		public const int FNLJPOJFHOAFieldNumber = 13;

		// Token: 0x04002C57 RID: 11351
		private uint fNLJPOJFHOA_;
	}
}
