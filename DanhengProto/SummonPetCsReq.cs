using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001209 RID: 4617
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SummonPetCsReq : IMessage<SummonPetCsReq>, IMessage, IEquatable<SummonPetCsReq>, IDeepCloneable<SummonPetCsReq>, IBufferMessage
	{
		// Token: 0x17003A34 RID: 14900
		// (get) Token: 0x0600CE5E RID: 52830 RVA: 0x00229A04 File Offset: 0x00227C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SummonPetCsReq> Parser
		{
			get
			{
				return SummonPetCsReq._parser;
			}
		}

		// Token: 0x17003A35 RID: 14901
		// (get) Token: 0x0600CE5F RID: 52831 RVA: 0x00229A0B File Offset: 0x00227C0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SummonPetCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003A36 RID: 14902
		// (get) Token: 0x0600CE60 RID: 52832 RVA: 0x00229A1D File Offset: 0x00227C1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SummonPetCsReq.Descriptor;
			}
		}

		// Token: 0x0600CE61 RID: 52833 RVA: 0x00229A24 File Offset: 0x00227C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonPetCsReq()
		{
		}

		// Token: 0x0600CE62 RID: 52834 RVA: 0x00229A2C File Offset: 0x00227C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonPetCsReq(SummonPetCsReq other) : this()
		{
			this.summonedPetId_ = other.summonedPetId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CE63 RID: 52835 RVA: 0x00229A51 File Offset: 0x00227C51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonPetCsReq Clone()
		{
			return new SummonPetCsReq(this);
		}

		// Token: 0x17003A37 RID: 14903
		// (get) Token: 0x0600CE64 RID: 52836 RVA: 0x00229A59 File Offset: 0x00227C59
		// (set) Token: 0x0600CE65 RID: 52837 RVA: 0x00229A61 File Offset: 0x00227C61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SummonedPetId
		{
			get
			{
				return this.summonedPetId_;
			}
			set
			{
				this.summonedPetId_ = value;
			}
		}

		// Token: 0x0600CE66 RID: 52838 RVA: 0x00229A6A File Offset: 0x00227C6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SummonPetCsReq);
		}

		// Token: 0x0600CE67 RID: 52839 RVA: 0x00229A78 File Offset: 0x00227C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SummonPetCsReq other)
		{
			return other != null && (other == this || (this.SummonedPetId == other.SummonedPetId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CE68 RID: 52840 RVA: 0x00229AA8 File Offset: 0x00227CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SummonedPetId != 0U)
			{
				num ^= this.SummonedPetId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CE69 RID: 52841 RVA: 0x00229AE7 File Offset: 0x00227CE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CE6A RID: 52842 RVA: 0x00229AEF File Offset: 0x00227CEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CE6B RID: 52843 RVA: 0x00229AF8 File Offset: 0x00227CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SummonedPetId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.SummonedPetId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CE6C RID: 52844 RVA: 0x00229B2C File Offset: 0x00227D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SummonedPetId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SummonedPetId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CE6D RID: 52845 RVA: 0x00229B6A File Offset: 0x00227D6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SummonPetCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SummonedPetId != 0U)
			{
				this.SummonedPetId = other.SummonedPetId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CE6E RID: 52846 RVA: 0x00229B9B File Offset: 0x00227D9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CE6F RID: 52847 RVA: 0x00229BA4 File Offset: 0x00227DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SummonedPetId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005324 RID: 21284
		private static readonly MessageParser<SummonPetCsReq> _parser = new MessageParser<SummonPetCsReq>(() => new SummonPetCsReq());

		// Token: 0x04005325 RID: 21285
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005326 RID: 21286
		public const int SummonedPetIdFieldNumber = 15;

		// Token: 0x04005327 RID: 21287
		private uint summonedPetId_;
	}
}
