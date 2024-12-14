using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000347 RID: 839
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DAGLHMKLOGO : IMessage<DAGLHMKLOGO>, IMessage, IEquatable<DAGLHMKLOGO>, IDeepCloneable<DAGLHMKLOGO>, IBufferMessage
	{
		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x06002571 RID: 9585 RVA: 0x00069998 File Offset: 0x00067B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DAGLHMKLOGO> Parser
		{
			get
			{
				return DAGLHMKLOGO._parser;
			}
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x06002572 RID: 9586 RVA: 0x0006999F File Offset: 0x00067B9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DAGLHMKLOGOReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06002573 RID: 9587 RVA: 0x000699B1 File Offset: 0x00067BB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DAGLHMKLOGO.Descriptor;
			}
		}

		// Token: 0x06002574 RID: 9588 RVA: 0x000699B8 File Offset: 0x00067BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DAGLHMKLOGO()
		{
		}

		// Token: 0x06002575 RID: 9589 RVA: 0x000699CB File Offset: 0x00067BCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DAGLHMKLOGO(DAGLHMKLOGO other) : this()
		{
			this.kOPCHACOGFN_ = other.kOPCHACOGFN_.Clone();
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002576 RID: 9590 RVA: 0x00069A01 File Offset: 0x00067C01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DAGLHMKLOGO Clone()
		{
			return new DAGLHMKLOGO(this);
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06002577 RID: 9591 RVA: 0x00069A09 File Offset: 0x00067C09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> KOPCHACOGFN
		{
			get
			{
				return this.kOPCHACOGFN_;
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06002578 RID: 9592 RVA: 0x00069A11 File Offset: 0x00067C11
		// (set) Token: 0x06002579 RID: 9593 RVA: 0x00069A19 File Offset: 0x00067C19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x0600257A RID: 9594 RVA: 0x00069A22 File Offset: 0x00067C22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DAGLHMKLOGO);
		}

		// Token: 0x0600257B RID: 9595 RVA: 0x00069A30 File Offset: 0x00067C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DAGLHMKLOGO other)
		{
			return other != null && (other == this || (this.kOPCHACOGFN_.Equals(other.kOPCHACOGFN_) && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600257C RID: 9596 RVA: 0x00069A80 File Offset: 0x00067C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.kOPCHACOGFN_.GetHashCode();
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600257D RID: 9597 RVA: 0x00069ACD File Offset: 0x00067CCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600257E RID: 9598 RVA: 0x00069AD5 File Offset: 0x00067CD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600257F RID: 9599 RVA: 0x00069AE0 File Offset: 0x00067CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.kOPCHACOGFN_.WriteTo(ref output, DAGLHMKLOGO._repeated_kOPCHACOGFN_codec);
			if (this.Id != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002580 RID: 9600 RVA: 0x00069B30 File Offset: 0x00067D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.kOPCHACOGFN_.CalculateSize(DAGLHMKLOGO._repeated_kOPCHACOGFN_codec);
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002581 RID: 9601 RVA: 0x00069B84 File Offset: 0x00067D84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DAGLHMKLOGO other)
		{
			if (other == null)
			{
				return;
			}
			this.kOPCHACOGFN_.Add(other.kOPCHACOGFN_);
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002582 RID: 9602 RVA: 0x00069BD1 File Offset: 0x00067DD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002583 RID: 9603 RVA: 0x00069BDC File Offset: 0x00067DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U && num != 98U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadUInt32();
					}
				}
				else
				{
					this.kOPCHACOGFN_.AddEntriesFrom(ref input, DAGLHMKLOGO._repeated_kOPCHACOGFN_codec);
				}
			}
		}

		// Token: 0x04000F41 RID: 3905
		private static readonly MessageParser<DAGLHMKLOGO> _parser = new MessageParser<DAGLHMKLOGO>(() => new DAGLHMKLOGO());

		// Token: 0x04000F42 RID: 3906
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F43 RID: 3907
		public const int KOPCHACOGFNFieldNumber = 12;

		// Token: 0x04000F44 RID: 3908
		private static readonly FieldCodec<uint> _repeated_kOPCHACOGFN_codec = FieldCodec.ForUInt32(98U);

		// Token: 0x04000F45 RID: 3909
		private readonly RepeatedField<uint> kOPCHACOGFN_ = new RepeatedField<uint>();

		// Token: 0x04000F46 RID: 3910
		public const int IdFieldNumber = 13;

		// Token: 0x04000F47 RID: 3911
		private uint id_;
	}
}
