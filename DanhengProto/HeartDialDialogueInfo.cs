using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200089D RID: 2205
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HeartDialDialogueInfo : IMessage<HeartDialDialogueInfo>, IMessage, IEquatable<HeartDialDialogueInfo>, IDeepCloneable<HeartDialDialogueInfo>, IBufferMessage
	{
		// Token: 0x17001BB3 RID: 7091
		// (get) Token: 0x06006269 RID: 25193 RVA: 0x001075DD File Offset: 0x001057DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HeartDialDialogueInfo> Parser
		{
			get
			{
				return HeartDialDialogueInfo._parser;
			}
		}

		// Token: 0x17001BB4 RID: 7092
		// (get) Token: 0x0600626A RID: 25194 RVA: 0x001075E4 File Offset: 0x001057E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeartDialDialogueInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001BB5 RID: 7093
		// (get) Token: 0x0600626B RID: 25195 RVA: 0x001075F6 File Offset: 0x001057F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeartDialDialogueInfo.Descriptor;
			}
		}

		// Token: 0x0600626C RID: 25196 RVA: 0x001075FD File Offset: 0x001057FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeartDialDialogueInfo()
		{
		}

		// Token: 0x0600626D RID: 25197 RVA: 0x00107605 File Offset: 0x00105805
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeartDialDialogueInfo(HeartDialDialogueInfo other) : this()
		{
			this.dialogueId_ = other.dialogueId_;
			this.hOKOGGHDNMB_ = other.hOKOGGHDNMB_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600626E RID: 25198 RVA: 0x00107636 File Offset: 0x00105836
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeartDialDialogueInfo Clone()
		{
			return new HeartDialDialogueInfo(this);
		}

		// Token: 0x17001BB6 RID: 7094
		// (get) Token: 0x0600626F RID: 25199 RVA: 0x0010763E File Offset: 0x0010583E
		// (set) Token: 0x06006270 RID: 25200 RVA: 0x00107646 File Offset: 0x00105846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DialogueId
		{
			get
			{
				return this.dialogueId_;
			}
			set
			{
				this.dialogueId_ = value;
			}
		}

		// Token: 0x17001BB7 RID: 7095
		// (get) Token: 0x06006271 RID: 25201 RVA: 0x0010764F File Offset: 0x0010584F
		// (set) Token: 0x06006272 RID: 25202 RVA: 0x00107657 File Offset: 0x00105857
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HOKOGGHDNMB
		{
			get
			{
				return this.hOKOGGHDNMB_;
			}
			set
			{
				this.hOKOGGHDNMB_ = value;
			}
		}

		// Token: 0x06006273 RID: 25203 RVA: 0x00107660 File Offset: 0x00105860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeartDialDialogueInfo);
		}

		// Token: 0x06006274 RID: 25204 RVA: 0x0010766E File Offset: 0x0010586E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HeartDialDialogueInfo other)
		{
			return other != null && (other == this || (this.DialogueId == other.DialogueId && this.HOKOGGHDNMB == other.HOKOGGHDNMB && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006275 RID: 25205 RVA: 0x001076AC File Offset: 0x001058AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DialogueId != 0U)
			{
				num ^= this.DialogueId.GetHashCode();
			}
			if (this.HOKOGGHDNMB)
			{
				num ^= this.HOKOGGHDNMB.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006276 RID: 25206 RVA: 0x00107704 File Offset: 0x00105904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006277 RID: 25207 RVA: 0x0010770C File Offset: 0x0010590C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006278 RID: 25208 RVA: 0x00107718 File Offset: 0x00105918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DialogueId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.DialogueId);
			}
			if (this.HOKOGGHDNMB)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.HOKOGGHDNMB);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006279 RID: 25209 RVA: 0x00107774 File Offset: 0x00105974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DialogueId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DialogueId);
			}
			if (this.HOKOGGHDNMB)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600627A RID: 25210 RVA: 0x001077C0 File Offset: 0x001059C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HeartDialDialogueInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DialogueId != 0U)
			{
				this.DialogueId = other.DialogueId;
			}
			if (other.HOKOGGHDNMB)
			{
				this.HOKOGGHDNMB = other.HOKOGGHDNMB;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600627B RID: 25211 RVA: 0x00107810 File Offset: 0x00105A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600627C RID: 25212 RVA: 0x0010781C File Offset: 0x00105A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.HOKOGGHDNMB = input.ReadBool();
					}
				}
				else
				{
					this.DialogueId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040025D1 RID: 9681
		private static readonly MessageParser<HeartDialDialogueInfo> _parser = new MessageParser<HeartDialDialogueInfo>(() => new HeartDialDialogueInfo());

		// Token: 0x040025D2 RID: 9682
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025D3 RID: 9683
		public const int DialogueIdFieldNumber = 8;

		// Token: 0x040025D4 RID: 9684
		private uint dialogueId_;

		// Token: 0x040025D5 RID: 9685
		public const int HOKOGGHDNMBFieldNumber = 11;

		// Token: 0x040025D6 RID: 9686
		private bool hOKOGGHDNMB_;
	}
}
