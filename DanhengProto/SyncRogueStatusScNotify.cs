using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200129F RID: 4767
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SyncRogueStatusScNotify : IMessage<SyncRogueStatusScNotify>, IMessage, IEquatable<SyncRogueStatusScNotify>, IDeepCloneable<SyncRogueStatusScNotify>, IBufferMessage
	{
		// Token: 0x17003BD4 RID: 15316
		// (get) Token: 0x0600D4AB RID: 54443 RVA: 0x00237EA1 File Offset: 0x002360A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SyncRogueStatusScNotify> Parser
		{
			get
			{
				return SyncRogueStatusScNotify._parser;
			}
		}

		// Token: 0x17003BD5 RID: 15317
		// (get) Token: 0x0600D4AC RID: 54444 RVA: 0x00237EA8 File Offset: 0x002360A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SyncRogueStatusScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003BD6 RID: 15318
		// (get) Token: 0x0600D4AD RID: 54445 RVA: 0x00237EBA File Offset: 0x002360BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncRogueStatusScNotify.Descriptor;
			}
		}

		// Token: 0x0600D4AE RID: 54446 RVA: 0x00237EC1 File Offset: 0x002360C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueStatusScNotify()
		{
		}

		// Token: 0x0600D4AF RID: 54447 RVA: 0x00237EC9 File Offset: 0x002360C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueStatusScNotify(SyncRogueStatusScNotify other) : this()
		{
			this.mMGFCILICND_ = other.mMGFCILICND_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D4B0 RID: 54448 RVA: 0x00237EFA File Offset: 0x002360FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueStatusScNotify Clone()
		{
			return new SyncRogueStatusScNotify(this);
		}

		// Token: 0x17003BD7 RID: 15319
		// (get) Token: 0x0600D4B1 RID: 54449 RVA: 0x00237F02 File Offset: 0x00236102
		// (set) Token: 0x0600D4B2 RID: 54450 RVA: 0x00237F0A File Offset: 0x0023610A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool MMGFCILICND
		{
			get
			{
				return this.mMGFCILICND_;
			}
			set
			{
				this.mMGFCILICND_ = value;
			}
		}

		// Token: 0x17003BD8 RID: 15320
		// (get) Token: 0x0600D4B3 RID: 54451 RVA: 0x00237F13 File Offset: 0x00236113
		// (set) Token: 0x0600D4B4 RID: 54452 RVA: 0x00237F1B File Offset: 0x0023611B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueStatus Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x0600D4B5 RID: 54453 RVA: 0x00237F24 File Offset: 0x00236124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncRogueStatusScNotify);
		}

		// Token: 0x0600D4B6 RID: 54454 RVA: 0x00237F32 File Offset: 0x00236132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SyncRogueStatusScNotify other)
		{
			return other != null && (other == this || (this.MMGFCILICND == other.MMGFCILICND && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D4B7 RID: 54455 RVA: 0x00237F70 File Offset: 0x00236170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MMGFCILICND)
			{
				num ^= this.MMGFCILICND.GetHashCode();
			}
			if (this.Status != RogueStatus.None)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D4B8 RID: 54456 RVA: 0x00237FCE File Offset: 0x002361CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D4B9 RID: 54457 RVA: 0x00237FD6 File Offset: 0x002361D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D4BA RID: 54458 RVA: 0x00237FE0 File Offset: 0x002361E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MMGFCILICND)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.MMGFCILICND);
			}
			if (this.Status != RogueStatus.None)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D4BB RID: 54459 RVA: 0x0023803C File Offset: 0x0023623C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MMGFCILICND)
			{
				num += 2;
			}
			if (this.Status != RogueStatus.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D4BC RID: 54460 RVA: 0x00238088 File Offset: 0x00236288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SyncRogueStatusScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MMGFCILICND)
			{
				this.MMGFCILICND = other.MMGFCILICND;
			}
			if (other.Status != RogueStatus.None)
			{
				this.Status = other.Status;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D4BD RID: 54461 RVA: 0x002380D8 File Offset: 0x002362D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D4BE RID: 54462 RVA: 0x002380E4 File Offset: 0x002362E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Status = (RogueStatus)input.ReadEnum();
					}
				}
				else
				{
					this.MMGFCILICND = input.ReadBool();
				}
			}
		}

		// Token: 0x04005517 RID: 21783
		private static readonly MessageParser<SyncRogueStatusScNotify> _parser = new MessageParser<SyncRogueStatusScNotify>(() => new SyncRogueStatusScNotify());

		// Token: 0x04005518 RID: 21784
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005519 RID: 21785
		public const int MMGFCILICNDFieldNumber = 5;

		// Token: 0x0400551A RID: 21786
		private bool mMGFCILICND_;

		// Token: 0x0400551B RID: 21787
		public const int StatusFieldNumber = 7;

		// Token: 0x0400551C RID: 21788
		private RogueStatus status_;
	}
}
