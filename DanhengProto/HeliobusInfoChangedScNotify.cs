using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008BF RID: 2239
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HeliobusInfoChangedScNotify : IMessage<HeliobusInfoChangedScNotify>, IMessage, IEquatable<HeliobusInfoChangedScNotify>, IDeepCloneable<HeliobusInfoChangedScNotify>, IBufferMessage
	{
		// Token: 0x17001C20 RID: 7200
		// (get) Token: 0x060063D2 RID: 25554 RVA: 0x0010B713 File Offset: 0x00109913
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HeliobusInfoChangedScNotify> Parser
		{
			get
			{
				return HeliobusInfoChangedScNotify._parser;
			}
		}

		// Token: 0x17001C21 RID: 7201
		// (get) Token: 0x060063D3 RID: 25555 RVA: 0x0010B71A File Offset: 0x0010991A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeliobusInfoChangedScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001C22 RID: 7202
		// (get) Token: 0x060063D4 RID: 25556 RVA: 0x0010B72C File Offset: 0x0010992C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeliobusInfoChangedScNotify.Descriptor;
			}
		}

		// Token: 0x060063D5 RID: 25557 RVA: 0x0010B733 File Offset: 0x00109933
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusInfoChangedScNotify()
		{
		}

		// Token: 0x060063D6 RID: 25558 RVA: 0x0010B748 File Offset: 0x00109948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusInfoChangedScNotify(HeliobusInfoChangedScNotify other) : this()
		{
			this.phase_ = other.phase_;
			this.aIJHHHCOBFF_ = other.aIJHHHCOBFF_;
			this.jGKJJKFBLCF_ = other.jGKJJKFBLCF_;
			this.jNOIBBBGPKK_ = other.jNOIBBBGPKK_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060063D7 RID: 25559 RVA: 0x0010B7A1 File Offset: 0x001099A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusInfoChangedScNotify Clone()
		{
			return new HeliobusInfoChangedScNotify(this);
		}

		// Token: 0x17001C23 RID: 7203
		// (get) Token: 0x060063D8 RID: 25560 RVA: 0x0010B7A9 File Offset: 0x001099A9
		// (set) Token: 0x060063D9 RID: 25561 RVA: 0x0010B7B1 File Offset: 0x001099B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Phase
		{
			get
			{
				return this.phase_;
			}
			set
			{
				this.phase_ = value;
			}
		}

		// Token: 0x17001C24 RID: 7204
		// (get) Token: 0x060063DA RID: 25562 RVA: 0x0010B7BA File Offset: 0x001099BA
		// (set) Token: 0x060063DB RID: 25563 RVA: 0x0010B7C2 File Offset: 0x001099C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AIJHHHCOBFF
		{
			get
			{
				return this.aIJHHHCOBFF_;
			}
			set
			{
				this.aIJHHHCOBFF_ = value;
			}
		}

		// Token: 0x17001C25 RID: 7205
		// (get) Token: 0x060063DC RID: 25564 RVA: 0x0010B7CB File Offset: 0x001099CB
		// (set) Token: 0x060063DD RID: 25565 RVA: 0x0010B7D3 File Offset: 0x001099D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JGKJJKFBLCF
		{
			get
			{
				return this.jGKJJKFBLCF_;
			}
			set
			{
				this.jGKJJKFBLCF_ = value;
			}
		}

		// Token: 0x17001C26 RID: 7206
		// (get) Token: 0x060063DE RID: 25566 RVA: 0x0010B7DC File Offset: 0x001099DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PCMDGDLANFF> JNOIBBBGPKK
		{
			get
			{
				return this.jNOIBBBGPKK_;
			}
		}

		// Token: 0x060063DF RID: 25567 RVA: 0x0010B7E4 File Offset: 0x001099E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeliobusInfoChangedScNotify);
		}

		// Token: 0x060063E0 RID: 25568 RVA: 0x0010B7F4 File Offset: 0x001099F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HeliobusInfoChangedScNotify other)
		{
			return other != null && (other == this || (this.Phase == other.Phase && this.AIJHHHCOBFF == other.AIJHHHCOBFF && this.JGKJJKFBLCF == other.JGKJJKFBLCF && this.jNOIBBBGPKK_.Equals(other.jNOIBBBGPKK_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060063E1 RID: 25569 RVA: 0x0010B864 File Offset: 0x00109A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Phase != 0U)
			{
				num ^= this.Phase.GetHashCode();
			}
			if (this.AIJHHHCOBFF != 0U)
			{
				num ^= this.AIJHHHCOBFF.GetHashCode();
			}
			if (this.JGKJJKFBLCF != 0U)
			{
				num ^= this.JGKJJKFBLCF.GetHashCode();
			}
			num ^= this.jNOIBBBGPKK_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060063E2 RID: 25570 RVA: 0x0010B8E3 File Offset: 0x00109AE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060063E3 RID: 25571 RVA: 0x0010B8EB File Offset: 0x00109AEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060063E4 RID: 25572 RVA: 0x0010B8F4 File Offset: 0x00109AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.JGKJJKFBLCF != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.JGKJJKFBLCF);
			}
			this.jNOIBBBGPKK_.WriteTo(ref output, HeliobusInfoChangedScNotify._repeated_jNOIBBBGPKK_codec);
			if (this.AIJHHHCOBFF != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.AIJHHHCOBFF);
			}
			if (this.Phase != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Phase);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060063E5 RID: 25573 RVA: 0x0010B97C File Offset: 0x00109B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Phase != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Phase);
			}
			if (this.AIJHHHCOBFF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AIJHHHCOBFF);
			}
			if (this.JGKJJKFBLCF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JGKJJKFBLCF);
			}
			num += this.jNOIBBBGPKK_.CalculateSize(HeliobusInfoChangedScNotify._repeated_jNOIBBBGPKK_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060063E6 RID: 25574 RVA: 0x0010BA00 File Offset: 0x00109C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HeliobusInfoChangedScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Phase != 0U)
			{
				this.Phase = other.Phase;
			}
			if (other.AIJHHHCOBFF != 0U)
			{
				this.AIJHHHCOBFF = other.AIJHHHCOBFF;
			}
			if (other.JGKJJKFBLCF != 0U)
			{
				this.JGKJJKFBLCF = other.JGKJJKFBLCF;
			}
			this.jNOIBBBGPKK_.Add(other.jNOIBBBGPKK_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060063E7 RID: 25575 RVA: 0x0010BA75 File Offset: 0x00109C75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060063E8 RID: 25576 RVA: 0x0010BA80 File Offset: 0x00109C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 50U)
				{
					if (num == 32U)
					{
						this.JGKJJKFBLCF = input.ReadUInt32();
						continue;
					}
					if (num == 50U)
					{
						this.jNOIBBBGPKK_.AddEntriesFrom(ref input, HeliobusInfoChangedScNotify._repeated_jNOIBBBGPKK_codec);
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.AIJHHHCOBFF = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.Phase = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400267D RID: 9853
		private static readonly MessageParser<HeliobusInfoChangedScNotify> _parser = new MessageParser<HeliobusInfoChangedScNotify>(() => new HeliobusInfoChangedScNotify());

		// Token: 0x0400267E RID: 9854
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400267F RID: 9855
		public const int PhaseFieldNumber = 13;

		// Token: 0x04002680 RID: 9856
		private uint phase_;

		// Token: 0x04002681 RID: 9857
		public const int AIJHHHCOBFFFieldNumber = 10;

		// Token: 0x04002682 RID: 9858
		private uint aIJHHHCOBFF_;

		// Token: 0x04002683 RID: 9859
		public const int JGKJJKFBLCFFieldNumber = 4;

		// Token: 0x04002684 RID: 9860
		private uint jGKJJKFBLCF_;

		// Token: 0x04002685 RID: 9861
		public const int JNOIBBBGPKKFieldNumber = 6;

		// Token: 0x04002686 RID: 9862
		private static readonly FieldCodec<PCMDGDLANFF> _repeated_jNOIBBBGPKK_codec = FieldCodec.ForMessage<PCMDGDLANFF>(50U, PCMDGDLANFF.Parser);

		// Token: 0x04002687 RID: 9863
		private readonly RepeatedField<PCMDGDLANFF> jNOIBBBGPKK_ = new RepeatedField<PCMDGDLANFF>();
	}
}
