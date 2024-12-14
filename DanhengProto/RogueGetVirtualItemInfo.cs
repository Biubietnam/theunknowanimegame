using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E9B RID: 3739
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueGetVirtualItemInfo : IMessage<RogueGetVirtualItemInfo>, IMessage, IEquatable<RogueGetVirtualItemInfo>, IDeepCloneable<RogueGetVirtualItemInfo>, IBufferMessage
	{
		// Token: 0x17002F33 RID: 12083
		// (get) Token: 0x0600A710 RID: 42768 RVA: 0x001C21DD File Offset: 0x001C03DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueGetVirtualItemInfo> Parser
		{
			get
			{
				return RogueGetVirtualItemInfo._parser;
			}
		}

		// Token: 0x17002F34 RID: 12084
		// (get) Token: 0x0600A711 RID: 42769 RVA: 0x001C21E4 File Offset: 0x001C03E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueGetVirtualItemInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002F35 RID: 12085
		// (get) Token: 0x0600A712 RID: 42770 RVA: 0x001C21F6 File Offset: 0x001C03F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueGetVirtualItemInfo.Descriptor;
			}
		}

		// Token: 0x0600A713 RID: 42771 RVA: 0x001C21FD File Offset: 0x001C03FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGetVirtualItemInfo()
		{
		}

		// Token: 0x0600A714 RID: 42772 RVA: 0x001C2205 File Offset: 0x001C0405
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGetVirtualItemInfo(RogueGetVirtualItemInfo other) : this()
		{
			this.iFOAOJNJEFI_ = other.iFOAOJNJEFI_;
			this.bPDBKNPHLDF_ = other.bPDBKNPHLDF_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A715 RID: 42773 RVA: 0x001C2236 File Offset: 0x001C0436
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGetVirtualItemInfo Clone()
		{
			return new RogueGetVirtualItemInfo(this);
		}

		// Token: 0x17002F36 RID: 12086
		// (get) Token: 0x0600A716 RID: 42774 RVA: 0x001C223E File Offset: 0x001C043E
		// (set) Token: 0x0600A717 RID: 42775 RVA: 0x001C2246 File Offset: 0x001C0446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint IFOAOJNJEFI
		{
			get
			{
				return this.iFOAOJNJEFI_;
			}
			set
			{
				this.iFOAOJNJEFI_ = value;
			}
		}

		// Token: 0x17002F37 RID: 12087
		// (get) Token: 0x0600A718 RID: 42776 RVA: 0x001C224F File Offset: 0x001C044F
		// (set) Token: 0x0600A719 RID: 42777 RVA: 0x001C2257 File Offset: 0x001C0457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BPDBKNPHLDF
		{
			get
			{
				return this.bPDBKNPHLDF_;
			}
			set
			{
				this.bPDBKNPHLDF_ = value;
			}
		}

		// Token: 0x0600A71A RID: 42778 RVA: 0x001C2260 File Offset: 0x001C0460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueGetVirtualItemInfo);
		}

		// Token: 0x0600A71B RID: 42779 RVA: 0x001C226E File Offset: 0x001C046E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueGetVirtualItemInfo other)
		{
			return other != null && (other == this || (this.IFOAOJNJEFI == other.IFOAOJNJEFI && this.BPDBKNPHLDF == other.BPDBKNPHLDF && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A71C RID: 42780 RVA: 0x001C22AC File Offset: 0x001C04AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IFOAOJNJEFI != 0U)
			{
				num ^= this.IFOAOJNJEFI.GetHashCode();
			}
			if (this.BPDBKNPHLDF != 0U)
			{
				num ^= this.BPDBKNPHLDF.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A71D RID: 42781 RVA: 0x001C2304 File Offset: 0x001C0504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A71E RID: 42782 RVA: 0x001C230C File Offset: 0x001C050C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A71F RID: 42783 RVA: 0x001C2318 File Offset: 0x001C0518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IFOAOJNJEFI != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.IFOAOJNJEFI);
			}
			if (this.BPDBKNPHLDF != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.BPDBKNPHLDF);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A720 RID: 42784 RVA: 0x001C2374 File Offset: 0x001C0574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IFOAOJNJEFI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IFOAOJNJEFI);
			}
			if (this.BPDBKNPHLDF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BPDBKNPHLDF);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A721 RID: 42785 RVA: 0x001C23CC File Offset: 0x001C05CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueGetVirtualItemInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IFOAOJNJEFI != 0U)
			{
				this.IFOAOJNJEFI = other.IFOAOJNJEFI;
			}
			if (other.BPDBKNPHLDF != 0U)
			{
				this.BPDBKNPHLDF = other.BPDBKNPHLDF;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A722 RID: 42786 RVA: 0x001C241C File Offset: 0x001C061C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A723 RID: 42787 RVA: 0x001C2428 File Offset: 0x001C0628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BPDBKNPHLDF = input.ReadUInt32();
					}
				}
				else
				{
					this.IFOAOJNJEFI = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004455 RID: 17493
		private static readonly MessageParser<RogueGetVirtualItemInfo> _parser = new MessageParser<RogueGetVirtualItemInfo>(() => new RogueGetVirtualItemInfo());

		// Token: 0x04004456 RID: 17494
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004457 RID: 17495
		public const int IFOAOJNJEFIFieldNumber = 7;

		// Token: 0x04004458 RID: 17496
		private uint iFOAOJNJEFI_;

		// Token: 0x04004459 RID: 17497
		public const int BPDBKNPHLDFFieldNumber = 12;

		// Token: 0x0400445A RID: 17498
		private uint bPDBKNPHLDF_;
	}
}
