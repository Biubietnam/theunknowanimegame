using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200127F RID: 4735
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SyncRogueAeonScNotify : IMessage<SyncRogueAeonScNotify>, IMessage, IEquatable<SyncRogueAeonScNotify>, IDeepCloneable<SyncRogueAeonScNotify>, IBufferMessage
	{
		// Token: 0x17003B73 RID: 15219
		// (get) Token: 0x0600D343 RID: 54083 RVA: 0x002344B9 File Offset: 0x002326B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SyncRogueAeonScNotify> Parser
		{
			get
			{
				return SyncRogueAeonScNotify._parser;
			}
		}

		// Token: 0x17003B74 RID: 15220
		// (get) Token: 0x0600D344 RID: 54084 RVA: 0x002344C0 File Offset: 0x002326C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SyncRogueAeonScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003B75 RID: 15221
		// (get) Token: 0x0600D345 RID: 54085 RVA: 0x002344D2 File Offset: 0x002326D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncRogueAeonScNotify.Descriptor;
			}
		}

		// Token: 0x0600D346 RID: 54086 RVA: 0x002344D9 File Offset: 0x002326D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueAeonScNotify()
		{
		}

		// Token: 0x0600D347 RID: 54087 RVA: 0x002344E1 File Offset: 0x002326E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueAeonScNotify(SyncRogueAeonScNotify other) : this()
		{
			this.jHNJCDMGGIH_ = ((other.jHNJCDMGGIH_ != null) ? other.jHNJCDMGGIH_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D348 RID: 54088 RVA: 0x00234516 File Offset: 0x00232716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueAeonScNotify Clone()
		{
			return new SyncRogueAeonScNotify(this);
		}

		// Token: 0x17003B76 RID: 15222
		// (get) Token: 0x0600D349 RID: 54089 RVA: 0x0023451E File Offset: 0x0023271E
		// (set) Token: 0x0600D34A RID: 54090 RVA: 0x00234526 File Offset: 0x00232726
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HGIOBKCNLNG JHNJCDMGGIH
		{
			get
			{
				return this.jHNJCDMGGIH_;
			}
			set
			{
				this.jHNJCDMGGIH_ = value;
			}
		}

		// Token: 0x0600D34B RID: 54091 RVA: 0x0023452F File Offset: 0x0023272F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncRogueAeonScNotify);
		}

		// Token: 0x0600D34C RID: 54092 RVA: 0x0023453D File Offset: 0x0023273D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SyncRogueAeonScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.JHNJCDMGGIH, other.JHNJCDMGGIH) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D34D RID: 54093 RVA: 0x00234570 File Offset: 0x00232770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.jHNJCDMGGIH_ != null)
			{
				num ^= this.JHNJCDMGGIH.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D34E RID: 54094 RVA: 0x002345AC File Offset: 0x002327AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D34F RID: 54095 RVA: 0x002345B4 File Offset: 0x002327B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D350 RID: 54096 RVA: 0x002345BD File Offset: 0x002327BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.jHNJCDMGGIH_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.JHNJCDMGGIH);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D351 RID: 54097 RVA: 0x002345F0 File Offset: 0x002327F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.jHNJCDMGGIH_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.JHNJCDMGGIH);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D352 RID: 54098 RVA: 0x00234630 File Offset: 0x00232830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SyncRogueAeonScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.jHNJCDMGGIH_ != null)
			{
				if (this.jHNJCDMGGIH_ == null)
				{
					this.JHNJCDMGGIH = new HGIOBKCNLNG();
				}
				this.JHNJCDMGGIH.MergeFrom(other.JHNJCDMGGIH);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D353 RID: 54099 RVA: 0x00234684 File Offset: 0x00232884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D354 RID: 54100 RVA: 0x00234690 File Offset: 0x00232890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.jHNJCDMGGIH_ == null)
					{
						this.JHNJCDMGGIH = new HGIOBKCNLNG();
					}
					input.ReadMessage(this.JHNJCDMGGIH);
				}
			}
		}

		// Token: 0x0400549B RID: 21659
		private static readonly MessageParser<SyncRogueAeonScNotify> _parser = new MessageParser<SyncRogueAeonScNotify>(() => new SyncRogueAeonScNotify());

		// Token: 0x0400549C RID: 21660
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400549D RID: 21661
		public const int JHNJCDMGGIHFieldNumber = 3;

		// Token: 0x0400549E RID: 21662
		private HGIOBKCNLNG jHNJCDMGGIH_;
	}
}
