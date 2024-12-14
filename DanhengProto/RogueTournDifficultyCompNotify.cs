using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F97 RID: 3991
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournDifficultyCompNotify : IMessage<RogueTournDifficultyCompNotify>, IMessage, IEquatable<RogueTournDifficultyCompNotify>, IDeepCloneable<RogueTournDifficultyCompNotify>, IBufferMessage
	{
		// Token: 0x1700322B RID: 12843
		// (get) Token: 0x0600B1D5 RID: 45525 RVA: 0x001DE1A4 File Offset: 0x001DC3A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournDifficultyCompNotify> Parser
		{
			get
			{
				return RogueTournDifficultyCompNotify._parser;
			}
		}

		// Token: 0x1700322C RID: 12844
		// (get) Token: 0x0600B1D6 RID: 45526 RVA: 0x001DE1AB File Offset: 0x001DC3AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournDifficultyCompNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700322D RID: 12845
		// (get) Token: 0x0600B1D7 RID: 45527 RVA: 0x001DE1BD File Offset: 0x001DC3BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournDifficultyCompNotify.Descriptor;
			}
		}

		// Token: 0x0600B1D8 RID: 45528 RVA: 0x001DE1C4 File Offset: 0x001DC3C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournDifficultyCompNotify()
		{
		}

		// Token: 0x0600B1D9 RID: 45529 RVA: 0x001DE1D7 File Offset: 0x001DC3D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournDifficultyCompNotify(RogueTournDifficultyCompNotify other) : this()
		{
			this.mHFHFNFCPCL_ = other.mHFHFNFCPCL_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B1DA RID: 45530 RVA: 0x001DE201 File Offset: 0x001DC401
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournDifficultyCompNotify Clone()
		{
			return new RogueTournDifficultyCompNotify(this);
		}

		// Token: 0x1700322E RID: 12846
		// (get) Token: 0x0600B1DB RID: 45531 RVA: 0x001DE209 File Offset: 0x001DC409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> MHFHFNFCPCL
		{
			get
			{
				return this.mHFHFNFCPCL_;
			}
		}

		// Token: 0x0600B1DC RID: 45532 RVA: 0x001DE211 File Offset: 0x001DC411
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournDifficultyCompNotify);
		}

		// Token: 0x0600B1DD RID: 45533 RVA: 0x001DE21F File Offset: 0x001DC41F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournDifficultyCompNotify other)
		{
			return other != null && (other == this || (this.mHFHFNFCPCL_.Equals(other.mHFHFNFCPCL_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B1DE RID: 45534 RVA: 0x001DE254 File Offset: 0x001DC454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.mHFHFNFCPCL_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B1DF RID: 45535 RVA: 0x001DE288 File Offset: 0x001DC488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B1E0 RID: 45536 RVA: 0x001DE290 File Offset: 0x001DC490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B1E1 RID: 45537 RVA: 0x001DE299 File Offset: 0x001DC499
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.mHFHFNFCPCL_.WriteTo(ref output, RogueTournDifficultyCompNotify._repeated_mHFHFNFCPCL_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B1E2 RID: 45538 RVA: 0x001DE2C0 File Offset: 0x001DC4C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.mHFHFNFCPCL_.CalculateSize(RogueTournDifficultyCompNotify._repeated_mHFHFNFCPCL_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B1E3 RID: 45539 RVA: 0x001DE2F9 File Offset: 0x001DC4F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournDifficultyCompNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.mHFHFNFCPCL_.Add(other.mHFHFNFCPCL_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B1E4 RID: 45540 RVA: 0x001DE327 File Offset: 0x001DC527
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B1E5 RID: 45541 RVA: 0x001DE330 File Offset: 0x001DC530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U && num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.mHFHFNFCPCL_.AddEntriesFrom(ref input, RogueTournDifficultyCompNotify._repeated_mHFHFNFCPCL_codec);
				}
			}
		}

		// Token: 0x04004856 RID: 18518
		private static readonly MessageParser<RogueTournDifficultyCompNotify> _parser = new MessageParser<RogueTournDifficultyCompNotify>(() => new RogueTournDifficultyCompNotify());

		// Token: 0x04004857 RID: 18519
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004858 RID: 18520
		public const int MHFHFNFCPCLFieldNumber = 11;

		// Token: 0x04004859 RID: 18521
		private static readonly FieldCodec<uint> _repeated_mHFHFNFCPCL_codec = FieldCodec.ForUInt32(90U);

		// Token: 0x0400485A RID: 18522
		private readonly RepeatedField<uint> mHFHFNFCPCL_ = new RepeatedField<uint>();
	}
}
