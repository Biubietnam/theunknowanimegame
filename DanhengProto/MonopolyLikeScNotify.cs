using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B5D RID: 2909
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyLikeScNotify : IMessage<MonopolyLikeScNotify>, IMessage, IEquatable<MonopolyLikeScNotify>, IDeepCloneable<MonopolyLikeScNotify>, IBufferMessage
	{
		// Token: 0x17002410 RID: 9232
		// (get) Token: 0x060080B9 RID: 32953 RVA: 0x001536A0 File Offset: 0x001518A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyLikeScNotify> Parser
		{
			get
			{
				return MonopolyLikeScNotify._parser;
			}
		}

		// Token: 0x17002411 RID: 9233
		// (get) Token: 0x060080BA RID: 32954 RVA: 0x001536A7 File Offset: 0x001518A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyLikeScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002412 RID: 9234
		// (get) Token: 0x060080BB RID: 32955 RVA: 0x001536B9 File Offset: 0x001518B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyLikeScNotify.Descriptor;
			}
		}

		// Token: 0x060080BC RID: 32956 RVA: 0x001536C0 File Offset: 0x001518C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyLikeScNotify()
		{
		}

		// Token: 0x060080BD RID: 32957 RVA: 0x001536D3 File Offset: 0x001518D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyLikeScNotify(MonopolyLikeScNotify other) : this()
		{
			this.aHEMHHBFKLC_ = other.aHEMHHBFKLC_.Clone();
			this.iMIJBGMIOMF_ = other.iMIJBGMIOMF_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060080BE RID: 32958 RVA: 0x00153709 File Offset: 0x00151909
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyLikeScNotify Clone()
		{
			return new MonopolyLikeScNotify(this);
		}

		// Token: 0x17002413 RID: 9235
		// (get) Token: 0x060080BF RID: 32959 RVA: 0x00153711 File Offset: 0x00151911
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AHEMHHBFKLC
		{
			get
			{
				return this.aHEMHHBFKLC_;
			}
		}

		// Token: 0x17002414 RID: 9236
		// (get) Token: 0x060080C0 RID: 32960 RVA: 0x00153719 File Offset: 0x00151919
		// (set) Token: 0x060080C1 RID: 32961 RVA: 0x00153721 File Offset: 0x00151921
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint IMIJBGMIOMF
		{
			get
			{
				return this.iMIJBGMIOMF_;
			}
			set
			{
				this.iMIJBGMIOMF_ = value;
			}
		}

		// Token: 0x060080C2 RID: 32962 RVA: 0x0015372A File Offset: 0x0015192A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyLikeScNotify);
		}

		// Token: 0x060080C3 RID: 32963 RVA: 0x00153738 File Offset: 0x00151938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyLikeScNotify other)
		{
			return other != null && (other == this || (this.aHEMHHBFKLC_.Equals(other.aHEMHHBFKLC_) && this.IMIJBGMIOMF == other.IMIJBGMIOMF && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060080C4 RID: 32964 RVA: 0x00153788 File Offset: 0x00151988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.aHEMHHBFKLC_.GetHashCode();
			if (this.IMIJBGMIOMF != 0U)
			{
				num ^= this.IMIJBGMIOMF.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060080C5 RID: 32965 RVA: 0x001537D5 File Offset: 0x001519D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060080C6 RID: 32966 RVA: 0x001537DD File Offset: 0x001519DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060080C7 RID: 32967 RVA: 0x001537E8 File Offset: 0x001519E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.aHEMHHBFKLC_.WriteTo(ref output, MonopolyLikeScNotify._repeated_aHEMHHBFKLC_codec);
			if (this.IMIJBGMIOMF != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.IMIJBGMIOMF);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060080C8 RID: 32968 RVA: 0x00153838 File Offset: 0x00151A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.aHEMHHBFKLC_.CalculateSize(MonopolyLikeScNotify._repeated_aHEMHHBFKLC_codec);
			if (this.IMIJBGMIOMF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IMIJBGMIOMF);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060080C9 RID: 32969 RVA: 0x0015388C File Offset: 0x00151A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyLikeScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.aHEMHHBFKLC_.Add(other.aHEMHHBFKLC_);
			if (other.IMIJBGMIOMF != 0U)
			{
				this.IMIJBGMIOMF = other.IMIJBGMIOMF;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060080CA RID: 32970 RVA: 0x001538D9 File Offset: 0x00151AD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060080CB RID: 32971 RVA: 0x001538E4 File Offset: 0x00151AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U && num != 58U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IMIJBGMIOMF = input.ReadUInt32();
					}
				}
				else
				{
					this.aHEMHHBFKLC_.AddEntriesFrom(ref input, MonopolyLikeScNotify._repeated_aHEMHHBFKLC_codec);
				}
			}
		}

		// Token: 0x0400312C RID: 12588
		private static readonly MessageParser<MonopolyLikeScNotify> _parser = new MessageParser<MonopolyLikeScNotify>(() => new MonopolyLikeScNotify());

		// Token: 0x0400312D RID: 12589
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400312E RID: 12590
		public const int AHEMHHBFKLCFieldNumber = 7;

		// Token: 0x0400312F RID: 12591
		private static readonly FieldCodec<uint> _repeated_aHEMHHBFKLC_codec = FieldCodec.ForUInt32(58U);

		// Token: 0x04003130 RID: 12592
		private readonly RepeatedField<uint> aHEMHHBFKLC_ = new RepeatedField<uint>();

		// Token: 0x04003131 RID: 12593
		public const int IMIJBGMIOMFFieldNumber = 13;

		// Token: 0x04003132 RID: 12594
		private uint iMIJBGMIOMF_;
	}
}
