using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200024D RID: 589
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueNousDiceSurfaceUnlockNotify : IMessage<ChessRogueNousDiceSurfaceUnlockNotify>, IMessage, IEquatable<ChessRogueNousDiceSurfaceUnlockNotify>, IDeepCloneable<ChessRogueNousDiceSurfaceUnlockNotify>, IBufferMessage
	{
		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06001A67 RID: 6759 RVA: 0x0004CB55 File Offset: 0x0004AD55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueNousDiceSurfaceUnlockNotify> Parser
		{
			get
			{
				return ChessRogueNousDiceSurfaceUnlockNotify._parser;
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06001A68 RID: 6760 RVA: 0x0004CB5C File Offset: 0x0004AD5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueNousDiceSurfaceUnlockNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06001A69 RID: 6761 RVA: 0x0004CB6E File Offset: 0x0004AD6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueNousDiceSurfaceUnlockNotify.Descriptor;
			}
		}

		// Token: 0x06001A6A RID: 6762 RVA: 0x0004CB75 File Offset: 0x0004AD75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueNousDiceSurfaceUnlockNotify()
		{
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x0004CB7D File Offset: 0x0004AD7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueNousDiceSurfaceUnlockNotify(ChessRogueNousDiceSurfaceUnlockNotify other) : this()
		{
			this.kIBFCKFHNMK_ = other.kIBFCKFHNMK_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001A6C RID: 6764 RVA: 0x0004CBA2 File Offset: 0x0004ADA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueNousDiceSurfaceUnlockNotify Clone()
		{
			return new ChessRogueNousDiceSurfaceUnlockNotify(this);
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06001A6D RID: 6765 RVA: 0x0004CBAA File Offset: 0x0004ADAA
		// (set) Token: 0x06001A6E RID: 6766 RVA: 0x0004CBB2 File Offset: 0x0004ADB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KIBFCKFHNMK
		{
			get
			{
				return this.kIBFCKFHNMK_;
			}
			set
			{
				this.kIBFCKFHNMK_ = value;
			}
		}

		// Token: 0x06001A6F RID: 6767 RVA: 0x0004CBBB File Offset: 0x0004ADBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueNousDiceSurfaceUnlockNotify);
		}

		// Token: 0x06001A70 RID: 6768 RVA: 0x0004CBC9 File Offset: 0x0004ADC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueNousDiceSurfaceUnlockNotify other)
		{
			return other != null && (other == this || (this.KIBFCKFHNMK == other.KIBFCKFHNMK && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x0004CBF8 File Offset: 0x0004ADF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.KIBFCKFHNMK != 0U)
			{
				num ^= this.KIBFCKFHNMK.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x0004CC37 File Offset: 0x0004AE37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x0004CC3F File Offset: 0x0004AE3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x0004CC48 File Offset: 0x0004AE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.KIBFCKFHNMK != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.KIBFCKFHNMK);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001A75 RID: 6773 RVA: 0x0004CC7C File Offset: 0x0004AE7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.KIBFCKFHNMK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KIBFCKFHNMK);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001A76 RID: 6774 RVA: 0x0004CCBA File Offset: 0x0004AEBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueNousDiceSurfaceUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.KIBFCKFHNMK != 0U)
			{
				this.KIBFCKFHNMK = other.KIBFCKFHNMK;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001A77 RID: 6775 RVA: 0x0004CCEB File Offset: 0x0004AEEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001A78 RID: 6776 RVA: 0x0004CCF4 File Offset: 0x0004AEF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.KIBFCKFHNMK = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000B3E RID: 2878
		private static readonly MessageParser<ChessRogueNousDiceSurfaceUnlockNotify> _parser = new MessageParser<ChessRogueNousDiceSurfaceUnlockNotify>(() => new ChessRogueNousDiceSurfaceUnlockNotify());

		// Token: 0x04000B3F RID: 2879
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000B40 RID: 2880
		public const int KIBFCKFHNMKFieldNumber = 5;

		// Token: 0x04000B41 RID: 2881
		private uint kIBFCKFHNMK_;
	}
}
