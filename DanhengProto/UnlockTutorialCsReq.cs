using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013CD RID: 5069
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UnlockTutorialCsReq : IMessage<UnlockTutorialCsReq>, IMessage, IEquatable<UnlockTutorialCsReq>, IDeepCloneable<UnlockTutorialCsReq>, IBufferMessage
	{
		// Token: 0x17003F77 RID: 16247
		// (get) Token: 0x0600E1F7 RID: 57847 RVA: 0x00259288 File Offset: 0x00257488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UnlockTutorialCsReq> Parser
		{
			get
			{
				return UnlockTutorialCsReq._parser;
			}
		}

		// Token: 0x17003F78 RID: 16248
		// (get) Token: 0x0600E1F8 RID: 57848 RVA: 0x0025928F File Offset: 0x0025748F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UnlockTutorialCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003F79 RID: 16249
		// (get) Token: 0x0600E1F9 RID: 57849 RVA: 0x002592A1 File Offset: 0x002574A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnlockTutorialCsReq.Descriptor;
			}
		}

		// Token: 0x0600E1FA RID: 57850 RVA: 0x002592A8 File Offset: 0x002574A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockTutorialCsReq()
		{
		}

		// Token: 0x0600E1FB RID: 57851 RVA: 0x002592B0 File Offset: 0x002574B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockTutorialCsReq(UnlockTutorialCsReq other) : this()
		{
			this.tutorialId_ = other.tutorialId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E1FC RID: 57852 RVA: 0x002592D5 File Offset: 0x002574D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockTutorialCsReq Clone()
		{
			return new UnlockTutorialCsReq(this);
		}

		// Token: 0x17003F7A RID: 16250
		// (get) Token: 0x0600E1FD RID: 57853 RVA: 0x002592DD File Offset: 0x002574DD
		// (set) Token: 0x0600E1FE RID: 57854 RVA: 0x002592E5 File Offset: 0x002574E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TutorialId
		{
			get
			{
				return this.tutorialId_;
			}
			set
			{
				this.tutorialId_ = value;
			}
		}

		// Token: 0x0600E1FF RID: 57855 RVA: 0x002592EE File Offset: 0x002574EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnlockTutorialCsReq);
		}

		// Token: 0x0600E200 RID: 57856 RVA: 0x002592FC File Offset: 0x002574FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnlockTutorialCsReq other)
		{
			return other != null && (other == this || (this.TutorialId == other.TutorialId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E201 RID: 57857 RVA: 0x0025932C File Offset: 0x0025752C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TutorialId != 0U)
			{
				num ^= this.TutorialId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E202 RID: 57858 RVA: 0x0025936B File Offset: 0x0025756B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E203 RID: 57859 RVA: 0x00259373 File Offset: 0x00257573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E204 RID: 57860 RVA: 0x0025937C File Offset: 0x0025757C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TutorialId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.TutorialId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E205 RID: 57861 RVA: 0x002593B0 File Offset: 0x002575B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TutorialId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TutorialId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E206 RID: 57862 RVA: 0x002593EE File Offset: 0x002575EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnlockTutorialCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TutorialId != 0U)
			{
				this.TutorialId = other.TutorialId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E207 RID: 57863 RVA: 0x0025941F File Offset: 0x0025761F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E208 RID: 57864 RVA: 0x00259428 File Offset: 0x00257628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TutorialId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040059E9 RID: 23017
		private static readonly MessageParser<UnlockTutorialCsReq> _parser = new MessageParser<UnlockTutorialCsReq>(() => new UnlockTutorialCsReq());

		// Token: 0x040059EA RID: 23018
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059EB RID: 23019
		public const int TutorialIdFieldNumber = 2;

		// Token: 0x040059EC RID: 23020
		private uint tutorialId_;
	}
}
