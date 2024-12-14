using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013D1 RID: 5073
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UnlockTutorialGuideScRsp : IMessage<UnlockTutorialGuideScRsp>, IMessage, IEquatable<UnlockTutorialGuideScRsp>, IDeepCloneable<UnlockTutorialGuideScRsp>, IBufferMessage
	{
		// Token: 0x17003F81 RID: 16257
		// (get) Token: 0x0600E221 RID: 57889 RVA: 0x0025977D File Offset: 0x0025797D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UnlockTutorialGuideScRsp> Parser
		{
			get
			{
				return UnlockTutorialGuideScRsp._parser;
			}
		}

		// Token: 0x17003F82 RID: 16258
		// (get) Token: 0x0600E222 RID: 57890 RVA: 0x00259784 File Offset: 0x00257984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UnlockTutorialGuideScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003F83 RID: 16259
		// (get) Token: 0x0600E223 RID: 57891 RVA: 0x00259796 File Offset: 0x00257996
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnlockTutorialGuideScRsp.Descriptor;
			}
		}

		// Token: 0x0600E224 RID: 57892 RVA: 0x0025979D File Offset: 0x0025799D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockTutorialGuideScRsp()
		{
		}

		// Token: 0x0600E225 RID: 57893 RVA: 0x002597A8 File Offset: 0x002579A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockTutorialGuideScRsp(UnlockTutorialGuideScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.tutorialGuide_ = ((other.tutorialGuide_ != null) ? other.tutorialGuide_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E226 RID: 57894 RVA: 0x002597F4 File Offset: 0x002579F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockTutorialGuideScRsp Clone()
		{
			return new UnlockTutorialGuideScRsp(this);
		}

		// Token: 0x17003F84 RID: 16260
		// (get) Token: 0x0600E227 RID: 57895 RVA: 0x002597FC File Offset: 0x002579FC
		// (set) Token: 0x0600E228 RID: 57896 RVA: 0x00259804 File Offset: 0x00257A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x17003F85 RID: 16261
		// (get) Token: 0x0600E229 RID: 57897 RVA: 0x0025980D File Offset: 0x00257A0D
		// (set) Token: 0x0600E22A RID: 57898 RVA: 0x00259815 File Offset: 0x00257A15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialGuide TutorialGuide
		{
			get
			{
				return this.tutorialGuide_;
			}
			set
			{
				this.tutorialGuide_ = value;
			}
		}

		// Token: 0x0600E22B RID: 57899 RVA: 0x0025981E File Offset: 0x00257A1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnlockTutorialGuideScRsp);
		}

		// Token: 0x0600E22C RID: 57900 RVA: 0x0025982C File Offset: 0x00257A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnlockTutorialGuideScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.TutorialGuide, other.TutorialGuide) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E22D RID: 57901 RVA: 0x0025987C File Offset: 0x00257A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.tutorialGuide_ != null)
			{
				num ^= this.TutorialGuide.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E22E RID: 57902 RVA: 0x002598D1 File Offset: 0x00257AD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E22F RID: 57903 RVA: 0x002598D9 File Offset: 0x00257AD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E230 RID: 57904 RVA: 0x002598E4 File Offset: 0x00257AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			if (this.tutorialGuide_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.TutorialGuide);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E231 RID: 57905 RVA: 0x00259940 File Offset: 0x00257B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.tutorialGuide_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TutorialGuide);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E232 RID: 57906 RVA: 0x00259998 File Offset: 0x00257B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnlockTutorialGuideScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.tutorialGuide_ != null)
			{
				if (this.tutorialGuide_ == null)
				{
					this.TutorialGuide = new TutorialGuide();
				}
				this.TutorialGuide.MergeFrom(other.TutorialGuide);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E233 RID: 57907 RVA: 0x00259A00 File Offset: 0x00257C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E234 RID: 57908 RVA: 0x00259A0C File Offset: 0x00257C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.tutorialGuide_ == null)
						{
							this.TutorialGuide = new TutorialGuide();
						}
						input.ReadMessage(this.TutorialGuide);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040059F3 RID: 23027
		private static readonly MessageParser<UnlockTutorialGuideScRsp> _parser = new MessageParser<UnlockTutorialGuideScRsp>(() => new UnlockTutorialGuideScRsp());

		// Token: 0x040059F4 RID: 23028
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059F5 RID: 23029
		public const int RetcodeFieldNumber = 3;

		// Token: 0x040059F6 RID: 23030
		private uint retcode_;

		// Token: 0x040059F7 RID: 23031
		public const int TutorialGuideFieldNumber = 9;

		// Token: 0x040059F8 RID: 23032
		private TutorialGuide tutorialGuide_;
	}
}
