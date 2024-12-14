using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C7B RID: 3195
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PAJMDOHPIIK : IMessage<PAJMDOHPIIK>, IMessage, IEquatable<PAJMDOHPIIK>, IDeepCloneable<PAJMDOHPIIK>, IBufferMessage
	{
		// Token: 0x170027E2 RID: 10210
		// (get) Token: 0x06008DFF RID: 36351 RVA: 0x0017733C File Offset: 0x0017553C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PAJMDOHPIIK> Parser
		{
			get
			{
				return PAJMDOHPIIK._parser;
			}
		}

		// Token: 0x170027E3 RID: 10211
		// (get) Token: 0x06008E00 RID: 36352 RVA: 0x00177343 File Offset: 0x00175543
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PAJMDOHPIIKReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170027E4 RID: 10212
		// (get) Token: 0x06008E01 RID: 36353 RVA: 0x00177355 File Offset: 0x00175555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PAJMDOHPIIK.Descriptor;
			}
		}

		// Token: 0x06008E02 RID: 36354 RVA: 0x0017735C File Offset: 0x0017555C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PAJMDOHPIIK()
		{
		}

		// Token: 0x06008E03 RID: 36355 RVA: 0x0017736F File Offset: 0x0017556F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PAJMDOHPIIK(PAJMDOHPIIK other) : this()
		{
			this.gameStoryLineId_ = other.gameStoryLineId_;
			this.oFMIAGOIPJM_ = other.oFMIAGOIPJM_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008E04 RID: 36356 RVA: 0x001773A5 File Offset: 0x001755A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PAJMDOHPIIK Clone()
		{
			return new PAJMDOHPIIK(this);
		}

		// Token: 0x170027E5 RID: 10213
		// (get) Token: 0x06008E05 RID: 36357 RVA: 0x001773AD File Offset: 0x001755AD
		// (set) Token: 0x06008E06 RID: 36358 RVA: 0x001773B5 File Offset: 0x001755B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GameStoryLineId
		{
			get
			{
				return this.gameStoryLineId_;
			}
			set
			{
				this.gameStoryLineId_ = value;
			}
		}

		// Token: 0x170027E6 RID: 10214
		// (get) Token: 0x06008E07 RID: 36359 RVA: 0x001773BE File Offset: 0x001755BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> OFMIAGOIPJM
		{
			get
			{
				return this.oFMIAGOIPJM_;
			}
		}

		// Token: 0x06008E08 RID: 36360 RVA: 0x001773C6 File Offset: 0x001755C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PAJMDOHPIIK);
		}

		// Token: 0x06008E09 RID: 36361 RVA: 0x001773D4 File Offset: 0x001755D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PAJMDOHPIIK other)
		{
			return other != null && (other == this || (this.GameStoryLineId == other.GameStoryLineId && this.oFMIAGOIPJM_.Equals(other.oFMIAGOIPJM_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008E0A RID: 36362 RVA: 0x00177424 File Offset: 0x00175624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GameStoryLineId != 0U)
			{
				num ^= this.GameStoryLineId.GetHashCode();
			}
			num ^= this.oFMIAGOIPJM_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008E0B RID: 36363 RVA: 0x00177471 File Offset: 0x00175671
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008E0C RID: 36364 RVA: 0x00177479 File Offset: 0x00175679
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008E0D RID: 36365 RVA: 0x00177484 File Offset: 0x00175684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.oFMIAGOIPJM_.WriteTo(ref output, PAJMDOHPIIK._repeated_oFMIAGOIPJM_codec);
			if (this.GameStoryLineId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.GameStoryLineId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008E0E RID: 36366 RVA: 0x001774D4 File Offset: 0x001756D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GameStoryLineId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameStoryLineId);
			}
			num += this.oFMIAGOIPJM_.CalculateSize(PAJMDOHPIIK._repeated_oFMIAGOIPJM_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008E0F RID: 36367 RVA: 0x00177528 File Offset: 0x00175728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PAJMDOHPIIK other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GameStoryLineId != 0U)
			{
				this.GameStoryLineId = other.GameStoryLineId;
			}
			this.oFMIAGOIPJM_.Add(other.oFMIAGOIPJM_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008E10 RID: 36368 RVA: 0x00177575 File Offset: 0x00175775
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008E11 RID: 36369 RVA: 0x00177580 File Offset: 0x00175780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U && num != 82U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.GameStoryLineId = input.ReadUInt32();
					}
				}
				else
				{
					this.oFMIAGOIPJM_.AddEntriesFrom(ref input, PAJMDOHPIIK._repeated_oFMIAGOIPJM_codec);
				}
			}
		}

		// Token: 0x04003681 RID: 13953
		private static readonly MessageParser<PAJMDOHPIIK> _parser = new MessageParser<PAJMDOHPIIK>(() => new PAJMDOHPIIK());

		// Token: 0x04003682 RID: 13954
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003683 RID: 13955
		public const int GameStoryLineIdFieldNumber = 13;

		// Token: 0x04003684 RID: 13956
		private uint gameStoryLineId_;

		// Token: 0x04003685 RID: 13957
		public const int OFMIAGOIPJMFieldNumber = 10;

		// Token: 0x04003686 RID: 13958
		private static readonly FieldCodec<uint> _repeated_oFMIAGOIPJM_codec = FieldCodec.ForUInt32(82U);

		// Token: 0x04003687 RID: 13959
		private readonly RepeatedField<uint> oFMIAGOIPJM_ = new RepeatedField<uint>();
	}
}
