using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001299 RID: 4761
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SyncRogueReviveInfoScNotify : IMessage<SyncRogueReviveInfoScNotify>, IMessage, IEquatable<SyncRogueReviveInfoScNotify>, IDeepCloneable<SyncRogueReviveInfoScNotify>, IBufferMessage
	{
		// Token: 0x17003BC1 RID: 15297
		// (get) Token: 0x0600D464 RID: 54372 RVA: 0x00237255 File Offset: 0x00235455
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SyncRogueReviveInfoScNotify> Parser
		{
			get
			{
				return SyncRogueReviveInfoScNotify._parser;
			}
		}

		// Token: 0x17003BC2 RID: 15298
		// (get) Token: 0x0600D465 RID: 54373 RVA: 0x0023725C File Offset: 0x0023545C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SyncRogueReviveInfoScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003BC3 RID: 15299
		// (get) Token: 0x0600D466 RID: 54374 RVA: 0x0023726E File Offset: 0x0023546E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncRogueReviveInfoScNotify.Descriptor;
			}
		}

		// Token: 0x0600D467 RID: 54375 RVA: 0x00237275 File Offset: 0x00235475
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueReviveInfoScNotify()
		{
		}

		// Token: 0x0600D468 RID: 54376 RVA: 0x0023727D File Offset: 0x0023547D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueReviveInfoScNotify(SyncRogueReviveInfoScNotify other) : this()
		{
			this.reviveInfo_ = ((other.reviveInfo_ != null) ? other.reviveInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D469 RID: 54377 RVA: 0x002372B2 File Offset: 0x002354B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueReviveInfoScNotify Clone()
		{
			return new SyncRogueReviveInfoScNotify(this);
		}

		// Token: 0x17003BC4 RID: 15300
		// (get) Token: 0x0600D46A RID: 54378 RVA: 0x002372BA File Offset: 0x002354BA
		// (set) Token: 0x0600D46B RID: 54379 RVA: 0x002372C2 File Offset: 0x002354C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueReviveInfo ReviveInfo
		{
			get
			{
				return this.reviveInfo_;
			}
			set
			{
				this.reviveInfo_ = value;
			}
		}

		// Token: 0x0600D46C RID: 54380 RVA: 0x002372CB File Offset: 0x002354CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncRogueReviveInfoScNotify);
		}

		// Token: 0x0600D46D RID: 54381 RVA: 0x002372D9 File Offset: 0x002354D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SyncRogueReviveInfoScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ReviveInfo, other.ReviveInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D46E RID: 54382 RVA: 0x0023730C File Offset: 0x0023550C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.reviveInfo_ != null)
			{
				num ^= this.ReviveInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D46F RID: 54383 RVA: 0x00237348 File Offset: 0x00235548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D470 RID: 54384 RVA: 0x00237350 File Offset: 0x00235550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D471 RID: 54385 RVA: 0x00237359 File Offset: 0x00235559
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.reviveInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ReviveInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D472 RID: 54386 RVA: 0x0023738C File Offset: 0x0023558C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.reviveInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ReviveInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D473 RID: 54387 RVA: 0x002373CC File Offset: 0x002355CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SyncRogueReviveInfoScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.reviveInfo_ != null)
			{
				if (this.reviveInfo_ == null)
				{
					this.ReviveInfo = new RogueReviveInfo();
				}
				this.ReviveInfo.MergeFrom(other.ReviveInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D474 RID: 54388 RVA: 0x00237420 File Offset: 0x00235620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D475 RID: 54389 RVA: 0x0023742C File Offset: 0x0023562C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.reviveInfo_ == null)
					{
						this.ReviveInfo = new RogueReviveInfo();
					}
					input.ReadMessage(this.ReviveInfo);
				}
			}
		}

		// Token: 0x04005500 RID: 21760
		private static readonly MessageParser<SyncRogueReviveInfoScNotify> _parser = new MessageParser<SyncRogueReviveInfoScNotify>(() => new SyncRogueReviveInfoScNotify());

		// Token: 0x04005501 RID: 21761
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005502 RID: 21762
		public const int ReviveInfoFieldNumber = 1;

		// Token: 0x04005503 RID: 21763
		private RogueReviveInfo reviveInfo_;
	}
}
